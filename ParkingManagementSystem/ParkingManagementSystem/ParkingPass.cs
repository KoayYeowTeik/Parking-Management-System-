using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    public class ParkingPass
    {
        public int id { get; set; }
        public DateTime startDateTime { get; set; }
        public DateTime endDateTime { get; set; }
        public bool isParked { get; set; }

        //public MonthlyPassStatus status { get; set; }
        public PaymentMode paymentMode { get; set; }
        //public SeasonPassManager seasonPassManager { get; set; }
        public ParkingPass() { }

        public bool TerminatePass()
        {
            //implementation
            return false;
        }
        public void ChangeStatus()
        {
            //implementation
        }
        public void RefundRemainingPass()
        {
            //implementation
        }

        private PPState validState;
        private PPState expiredState;
        private PPState terminatedState;

        private PPState state;

        public PPState ValidState { get { return validState;  } }
        public PPState ExpiredState {  get { return expiredState; } }
        public PPState TerminatedState {  get { return terminatedState; } }

        public void setState(PPState state)
        {
            this.state = state;
        }

		public ParkingPass(int id, DateTime startDateTime, DateTime endDateTime, bool Parked, PaymentMode paymentMode)
		{
			this.id = id;
			this.startDateTime = startDateTime;
			this.endDateTime = endDateTime;
			this.isParked = Parked;
			this.paymentMode = paymentMode;

            validState = new ValidState(this);
            expiredState = new ExpiredState(this);
            terminatedState = new TerminatedState(this);

            if (endDateTime < DateTime.Today)
            {
                state = expiredState;
            }
            else
            {
                state = validState;
            }
        }

        public void enterParking()
        {
            state.enterCarpark();
		}

        public void exitParking()
        {
            state.exitCarpark();
        }

        public void renew()
        {
            state.renew();
        }

        public void terminate(string reasons)
        {
            state.terminate(reasons);
        }
	}
}
