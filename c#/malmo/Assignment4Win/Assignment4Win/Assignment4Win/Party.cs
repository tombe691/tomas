using System;

namespace Assignment4Win
{
    /// <summary>
    /// Party class for information regarding party
    /// </summary>
    class Party
    {
        /// <summary>
        /// attributes for the party class
        /// </summary>
        private double costPerCapita;
        private string[] guestList;

        //constructor - expect maxNumOfGuests to detirmine
        //the size of the array
        public Party (int maxNumOfGuests)
        {
            //create the array with this size
            guestList = new string[maxNumOfGuests];
        }
        /// <summary>
        /// method to calculate cost per person
        /// </summary>
        public double CostPerCapita
        {
            get { return costPerCapita; }
            set
            {
                if (value >= 0)
                    costPerCapita = value;
            }
        }
        /// <summary>
        /// method to add new guest with first name and last name from textfields
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public bool AddNewGuest (string firstName, string lastName)
        {
            bool ok = true;
            int vacantPos = FindVacantPos();
            if (vacantPos != -1)
            {
                guestList[vacantPos] = FullName(firstName, lastName);
            }
            else
                ok = false;

            return ok;
        }
        /// <summary>
        /// method to con cat first and lastname and change case to upper for last
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + ", " + firstName;
        }
        /// <summary>
        /// method to find first vacant postion in array/vector
        /// </summary>
        /// <returns></returns>
        private int FindVacantPos()
        {
            int vacantPos = -1;
            for (int index = 0; index < guestList.Length; index++)
            {
                if (string.IsNullOrEmpty(guestList[index]))
                {
                    vacantPos = index;
                    break;
                }
            }
            return vacantPos;
        }
        /// <summary>
        /// method to count number of guests
        /// </summary>
        /// <returns></returns>
        private int NumOfGuests()
        {
            int numGuests = 0;

            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    numGuests++;
                }
            }
            return numGuests;
        }
        /// <summary>
        /// method to call number of guests count method
        /// </summary>
        public int Count
        {
            get { return NumOfGuests(); }
        }
        /// <summary>
        /// method to calculate total cost by multipling number of guests with cost 
        /// per guest
        /// </summary>
        /// <returns></returns>
        public double CalcTotalCost()
        {
            int numOfGuests = NumOfGuests();
            double costPerCapita = CostPerCapita;
            Console.WriteLine("num {0} costper {1}", numOfGuests, costPerCapita);
            double totalCost = numOfGuests * costPerCapita;
            return totalCost;
        }
        /// <summary>
        /// return a copy of the guest list
        /// </summary>
        /// <returns></returns>
        public string[] GetGuestList()
        {
            int size = NumOfGuests();

            if (size <= 0)
                return null;

            string[] guests = new string[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty (guestList[i]))
                {
                    guests[j++] = guestList[i];
                }
            }
            return guests;
        }
        /// <summary>
        /// method to check if index is ok
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < guestList.Length);
        }
        /// <summary>
        /// method to return item at chosen index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetItemAt(int index)
        {
            if (CheckIndex(index))
                return guestList[index];

            return null;
        }
        /// <summary>
        /// method to delete entry on specific index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteAt(int index)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                guestList[index] = string.Empty;
                MoveElementsOneStepToLeft(index);
                ok = true;
            }
            return ok;
        }
        /// <summary>
        /// method to move elements to the left when an entry is deleted
        /// </summary>
        /// <param name="index"></param>
        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index+1;i<guestList.Length;i++)
            {
                guestList[i - 1] = guestList[i];
                guestList[i] = string.Empty;
            }
        }
        /// <summary>
        /// method to change entry at specific indes
        /// </summary>
        /// <param name="index"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public bool ChangeAt(int index, string firstName, string lastName)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                guestList[index] = FullName(firstName, lastName);
            }
            else
                ok = true;

            return ok;
        }
    }
}
