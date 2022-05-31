﻿using System;

namespace LearnInheritance
{
    class Bicycle : Vehicle
    {

        public Bicycle(double speed) : base(speed)
        {
            Wheels = 2;
        }

        public override void SpeedUp()
        {
            Speed += 5;

            if (Speed > 15)
            {
                Speed = 15;
                Console.WriteLine($"Max speed for bike is {Speed} km/h.");
            }
        }

        public override void SlowDown()
        {
            Speed -= 5;

            if (Speed < 0)
            {
                Speed = 0;
            }
        }

        public override string Describe()
        {
            return $"This Bicycle is moving on {Wheels} wheels at {Speed} km/h, with serial number {LicensePlate}.";
        }

    }
}
