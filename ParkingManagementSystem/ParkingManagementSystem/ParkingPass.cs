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
        public string passType { get; set; }
        public int userID { get; set; }
        public Applicants applicant {  get; set; }
        //public MonthlyPassStatus status { get; set; }
        //public PaymentMode paymentMode { get; set; }
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
        private PPState processingState;

        private PPState state;

        public PPState ProcessingState { get { return processingState; } }
        public PPState ValidState { get { return validState;  } }
        public PPState ExpiredState {  get { return expiredState; } }
        public PPState TerminatedState {  get { return terminatedState; } }

        public void setState(PPState state, MonthlyPassCollection collection)
        {
            this.state = state;
            if (state == ExpiredState)
            {
                if (passType == "Monthly")
                {
                    collection.removeFromCurrentPass(this);
                    this.state = ExpiredState;
                    Console.WriteLine("Pass is expired");
                }
                else if (passType == "Daily")
                {
                    this.state = ExpiredState;
                    Console.WriteLine("Daily pass expired");
                }
            }
        }

		public ParkingPass(int id, DateTime startDateTime, DateTime endDateTime, string passType, int userID) //PaymentMode paymentMode)
		{
			this.id = id;
			this.startDateTime = startDateTime;
			this.endDateTime = endDateTime;
            this.passType = passType;
            this.userID = userID;
            //this.applicant = applicants;
			//this.paymentMode = paymentMode;

            processingState = new ProcessingState(this);
            validState = new ValidState(this);
            expiredState = new ExpiredState(this);
            terminatedState = new TerminatedState(this);

            if (endDateTime < DateTime.Today)
            {
                state = expiredState;
            }
            else
            {
                state = processingState;
            }
        }

        public void approvePass(MonthlyPassCollection collection)
        {
            state.approvePass(collection);
        }

        public void enterParking()
        {
            state.enterCarpark();
		}

        public void exitParking()
        {
            state.exitCarpark();
        }

        public void renew(MonthlyPassCollection collection)
        {
            state.renew(collection);
        }

        public void terminate(string reasons, MonthlyPassCollection collection)
        {
            state.terminate(reasons, collection);
        }
	}
}
