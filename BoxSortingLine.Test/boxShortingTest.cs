using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxShortingLine.test
{
    public class boxShortingTest
    {
        [Fact]
        public void When_ParcelHasNewDimensionsAndSortingLineHasNewDimensions_ThenParcelCanNotFitSortingLine()
        {
            var boxSizes = new List<BoxSize>()

           {
               new BoxSize
                {
                    Length = 70,
                    Width = 50,
                    SortingLineParams = new List<SortingLineParam>
                    {
                        new SortingLineParam
                        {
                            Width = 60
                        },
                        new SortingLineParam
                        {
                            Width = 60
                        },
                        new SortingLineParam
                        {
                            Width = 55
                        },
                        new SortingLineParam
                        {
                            Width = 90
                        }
                    }
                }

             };

            bool result = Program.ParcelLine(boxSizes);

            Assert.False(result);
        }

    }

    internal class BoxSize
    {
        public int Length { get; internal set; }
        public List<SortingLineParam> SortingLineParams { get; internal set; }
        public int Width { get; internal set; }
    }
}

