using Cars.Common;
using Cars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars.Models
{
    public class Tesla : ICar, IElectricCar
    {

        private string model;
        private string color;
        private int battery;
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = battery;
        }

        public string Model
        {
            get => this.model;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Exceptions.NotValidName);
                }
                this.model = value;
            }
        }
        public string Color
        {
            get => this.color;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(Exceptions.NotValidColor);
                }
                this.color = value;
            }
        }
        public int Battery
        {
            get => this.battery;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(Exceptions.NotValidBatteryNumbers);
                }
                this.battery = value;
            }
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
                }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries")
                        .AppendLine(this.Start())
                        .Append(this.Stop());

            return sb.ToString().TrimEnd();
        }
    }
}
