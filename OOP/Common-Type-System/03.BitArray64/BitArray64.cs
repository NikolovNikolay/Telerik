using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Security.Cryptography;

namespace _03.BitArray64
{
    class BitArray64 : IEnumerable<int>
    {
        private readonly ulong number;
        
        // constructor
        public BitArray64(ulong number = 0)
        {
            this.number = number;
        }

        // indexer
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    int[] bits = this.GetBits();
                    return bits[index];
                }
            }
        }

        // int array property, representing bits
        public int[] Bits
        {
            get { return this.GetBits(); }
        }


        // Method for filling the 64 ellement array with 0 or 1, according to number
        private int[] GetBits()
        {
            ulong num = this.number;
            int bitIndex = 63;

            int[] bits = new int[64];

            while (num!=0)
            {
                bits[bitIndex] = (int)(num % 2);
                num /= 2;
                bitIndex--;
            }

            while (bitIndex >= 0)
            {
                bits[bitIndex] = 0;
                bitIndex--;
            }

            return bits;
        }


        // implementing the IEnumerable<int> 
        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.GetBits();

            for (int i = 0; i < bits.Length; i++)
            {
                yield return bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        // overriding methods

        // Equals
        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            return Enumerable.SequenceEqual(this, obj as BitArray64);
        }

        // Get hashcode
        public override int GetHashCode()
        {
            int[] bitz = this.GetBits();
            byte[] bits = new byte[64];
            for (int i = 0; i < 64; i++)
            {
                bits[i] = (byte)bitz[i];
            }
            return BitConverter.ToInt32(new MD5CryptoServiceProvider().ComputeHash(bits), 0);
        }

        //public override int GetHashCode()
        //{
        //    int hash = 17;

        //    unchecked
        //    {
        //        hash = hash * 23 + this.number.GetHashCode();
        //        return hash;
        //    }
        //}

        //overriding operators

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }
    }
}
