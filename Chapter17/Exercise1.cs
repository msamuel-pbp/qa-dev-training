﻿using System;
using System.Threading;
using NUnit.Framework;

namespace Chapter17 {
    [TestFixture]
    public class Exercise1 {
        public class AlarmEventArgs : EventArgs {
            public string Msg { get; set; }

            public AlarmEventArgs(string msg) {
                Msg = msg;
            }
        }

        public class AlarmClock {
            private string msg;
            private TimeSpan ts;

            public AlarmClock(string msg, TimeSpan ts) {
                this.msg = msg;
                this.ts = ts;
            }

            public delegate void AlarmHandler(object AlarmClock, AlarmEventArgs alarmInfo);
            public AlarmHandler Alarm; // intentionally made to be without event keyword

            public void Run() {
                while (true) {
                    var time = (int) ts.TotalSeconds;

                    Console.WriteLine("Waiting: {0} seconds", time);
                    Thread.Sleep(time * 1000);

                    if (Alarm != null) {
                        var alarmMessage = new AlarmEventArgs(msg);
                        Alarm(this, alarmMessage);
                    }                        
                }
            }
        }

        public class AutoFeeder {
            public AutoFeeder(AlarmClock alarmClock) {
                var feederHandler = new AlarmClock.AlarmHandler(RunFeeder);
                alarmClock.Alarm = feederHandler;
            }

            private void RunFeeder(object alarmClock, AlarmEventArgs alarmInfo) {
                Console.WriteLine("Alarm msg: {0}", alarmInfo.Msg);
            }
        }

        [Test]
        public void TestAlarm() {
            var clock = new AlarmClock("Run the damn feeder", new TimeSpan(0,0,5));
            var feeder = new AutoFeeder(clock);

            clock.Run();
        }
    }
}