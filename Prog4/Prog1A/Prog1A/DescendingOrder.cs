//Grading ID:E1749
//Prog 4
//Due: 11/23/2020
//CIS 200-76
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class DescendingOrder : Comparer<Parcel> //class for descending compare
    {
        //Pre: None
        //Post: two parcels are compared
        //compares two parcels w/ 3 if statements
        public override int Compare(Parcel x, Parcel y) 
        {
            if ((x == null && y == null))
                return 0;

            if (x == null)
                return -1;

            if (y == null)
                return 1;

            return (-1) * x.DestinationAddress.Zip.CompareTo(y.DestinationAddress.Zip);
        }
    }
}
