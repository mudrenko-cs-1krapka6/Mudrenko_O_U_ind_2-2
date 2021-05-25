/*
 * Created by SharpDevelop.
 * User: guyver
 * Date: 17.02.2020
 * Time: 10:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace carList
{
    /// <summary>
    /// Description of PersonListItem.
    /// </summary>
    public class carListItem
    {
        public car Cars { get; set; }
        public carListItem next { get; set; }
        public carListItem()
        {
            Cars.nomer_kuzov = 0;
            Cars.nomer = "n/d";
            Cars.when_obl_is_start = "n/d";
            Cars.when_obl_is_end = "n/d";
            Cars.year = "n/d";
            Cars.color = "n/d";
            //next=null;
        }
        public carListItem(uint nomer_kuzov, string nomer, string when_obl_is_start, string when_obl_is_end, string year, string color)
        {
            Cars.nomer_kuzov = nomer_kuzov;
            Cars.nomer = nomer;
            Cars.when_obl_is_start = when_obl_is_start;
            Cars.when_obl_is_end = when_obl_is_end;
            Cars.year = year;
            Cars.color = color;
            //next=null;
        }
        public carListItem(car c)
        {
            Cars = c;
            //next=null;
        }

    }
}