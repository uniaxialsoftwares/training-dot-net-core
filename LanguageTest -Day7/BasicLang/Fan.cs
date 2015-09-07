using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicLang
{
    public class Fan
    {
        private const int INC_DEC = 20;
        // variables

        #region Variables and Properties


        int _noOfWings = 0;
        public int WingsCount
        {
            set { _noOfWings = value; }
            get { return _noOfWings; }
        }
        public string Manufacturer { get; set; }
        public float CostPrice { get; set; }

        public bool IsRunning { get; set; }
        public float CurrentSpeed { get; set; }

        #endregion

        #region  Constructors
        public Fan() { } // Default Const

        public Fan(string paramManu, int paramNoOfWings)
        {
            this.WingsCount = paramNoOfWings;
            this.Manufacturer = paramManu;
        }
        public Fan(string paramManu, int paramNoOfWings, float paramCostPrice)
        {
            this.WingsCount = paramNoOfWings;
            this.Manufacturer = paramManu;
            this.CostPrice = paramCostPrice;
        }
        #endregion

        #region Function


        public void SwitchOn()
        {
            //if (this.IsRunning == false) this.IsRunning = true;
            if (!this.IsRunning) this.IsRunning = true;
        }
        public void SwitchOff()
        {
            if (this.IsRunning)
                this.IsRunning = false;
        }
        public void SpeedUp()
        {
            //CurrentSpeed = CurrentSpeed + 10;
            this.CurrentSpeed += INC_DEC;
        }
        public void SpeedDown()
        {
            //this.CurrentSpeed -= 10;
            //if (this.CurrentSpeed < 0) { this.CurrentSpeed = 0; }
            if (this.CurrentSpeed - INC_DEC >= 0)
            {
                this.CurrentSpeed -= INC_DEC;
            }

        }

        public void SpeedChange(float mySpeed)
        {
            if (this.CurrentSpeed + mySpeed >= 0)
            {
                this.CurrentSpeed = this.CurrentSpeed + mySpeed;
            }

        }
       

        
        #endregion
    }
}
