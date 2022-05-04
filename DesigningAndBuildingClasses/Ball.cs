using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesigningAndBuildingClasses
{
    internal class Ball
    {
        private int size;
        private int numberOfTimesThrown;
        private Color color;

        public Ball()
        {
            size = 1;
            numberOfTimesThrown = 0;
            color = new Color(255, 255, 255, 255);
        }
        public Ball(int size)
        {
            this.size = (size < 0) ? size * -1 : size;
            numberOfTimesThrown = 0;
            color = new Color(255, 255, 255, 255);
        }
        public Ball(int size, Color color)
        {
            this.size = (size < 0) ? size * -1 : size;
            this.color = color ?? new Color();
            numberOfTimesThrown = 0;
        }

        public string GetColor()
        {
            return color.GetColors();
        }

        public void Pop()
        {
            size = 0;
        }

        public void Throw()
        {
            if(size > 0)
            {
                this.numberOfTimesThrown++;
            }
        }
        public void Throw(int NumberOfTimes)
        {
            if (NumberOfTimes < 0)
            {
                return;
            }
            for (int index = 0; index < NumberOfTimes; index++)
            {
                Throw();
            }
        }

        public int GetSize()
        {
            return size;
        }

        public int NumberOfTimesThrown()
        {
            return this.numberOfTimesThrown;
        }
    }
}
