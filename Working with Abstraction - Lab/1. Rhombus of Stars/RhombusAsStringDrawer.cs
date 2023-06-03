using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    public class RhombusAsStringDrawer
    {
        public string Draw(int countOfStars)
        {
            StringBuilder sb = new StringBuilder();

            // top part of the Rhombus

            this.DrawTopPart(sb, countOfStars);

            // middle line of the rhombus

            this.DrawLineOfStars(sb, countOfStars);

            // bottom part of the rhombus

            this.DrawBottomPart(sb, countOfStars);

            return sb.ToString();
        }
        private void DrawLineOfStars(StringBuilder sb, int numberOfStars)
        {
            for (int stars = 0; stars < numberOfStars; stars++)
            {
                sb.Append("*");
                if (stars < numberOfStars - 1)
                {
                    sb.Append(" ");
                }
            }
            sb.AppendLine();
        }
        private void DrawTopPart(StringBuilder sb, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                sb.Append(new string(' ', n - i - 1));

                DrawLineOfStars(sb, i + 1);

            }
        }
        private void DrawBottomPart(StringBuilder sb, int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                sb.Append(new string(' ', n - i));

                DrawLineOfStars(sb, i);

            }
        }
    }
}
