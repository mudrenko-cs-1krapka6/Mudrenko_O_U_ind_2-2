/*
 * Created by SharpDevelop.
 * User: guyver
 * Date: 17.02.2020
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace carList
{
    /// <summary>
    /// Description of Person.
    /// </summary>
    public class /*struct*/ car : IEquatable<car>
    {
        public string nomer { get; set; }
        public string when_obl_is_start { get; set; }
        public string when_obl_is_end { get; set; }
        public string year { get; set; }
        public string color { get; set; }
        public uint nomer_kuzov { get; set; }

        public car()
        {
            nomer_kuzov = 0;
            nomer = when_obl_is_start = when_obl_is_end = year = color = " ";
        }
        public car(string nomer, string when_obl_is_start, string when_obl_is_end, string year, string color, uint nomer_kuzov = 0)
        {
            this.nomer = nomer;
            this.when_obl_is_start = when_obl_is_start;
            this.when_obl_is_end = when_obl_is_end;
            this.year = year;
            this.color = color;
            this.nomer_kuzov = nomer_kuzov;
        }

        public car(string[] list)
        {
            this.nomer = list[0];
            this.when_obl_is_start = list[1];
            this.when_obl_is_end = list[2];
            this.year = list[3];
            this.color = list[4];
            this.nomer_kuzov = uint.Parse(list[5]);
        }
        public override string ToString()
        {
            return nomer + " " + when_obl_is_start + " " + when_obl_is_end + " " + year + " " + color + " " + nomer_kuzov;
        }

        public override bool Equals(object obj)
        {
            if (obj is car)
                return Equals((car)obj); // use Equals method below
            else
                return false;
        }

        public bool Equals(car other)
        {
            // add comparisions for all members here
            if (this.nomer != other.nomer)
                return false;
            if (when_obl_is_start != other.when_obl_is_start)
                return false;
            if (when_obl_is_end != other.when_obl_is_end)
                return false;
            if (year != other.year)
                return false;
            if (color != other.color)
                return false;
            if (nomer_kuzov != other.nomer_kuzov)
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            // combine the hash codes of all members here (e.g. with XOR operator ^)
            return nomer.GetHashCode();
        }

        public static bool operator ==(car left, car right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(car left, car right)
        {
            return !left.Equals(right);
        }
    }
}