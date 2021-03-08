using Cars.Common;
using Cars.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Cars.Models
{
    public class Seat: ICar
    {
        private string model;
        private string color;
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {this.GetType().Name} {this.Model}")
                .AppendLine(this.Start())
                .Append(this.Stop());
            return sb.ToString();
        }


    }
}
