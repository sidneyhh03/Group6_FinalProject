using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
# Name: Shelby Sash
# email: sashsk@mail.uc.edu
# Assignment Title: Final Project
# Due Date: April 23, 2024
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: This hard level leet code problem creates 2 arrays and finds the median between them. 
# Citations: https://www.geeksforgeeks.org/median-two-sorted-arrays-different-sizes-ologminn-m/ , https://chat.openai.com/ , https://stackoverflow.com/questions/10180930/asp-net-open-new-webform-on-click-of-button
# Anything else that's relevant: N/A
*/
namespace Group6_FinalProject
{
    public partial class LeetCodeHard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] a = new int[] { 1, 2 };
            int[] b = new int[] { 3, 4 };
            int n = a.Length;
            int m = b.Length;

            // Call the findMedianSortedArrays method
            double median;
            if (n < m)
                median = findMedianSortedArrays(ref a, n, ref b, m);
            else
                median = findMedianSortedArrays(ref b, m, ref a, n);

            // Display the arrays and median

            lblArrayA.Text = "Array A: " + string.Join(", ", a);
            lblArrayB.Text = "Array B: " + string.Join(", ", b);
            lblMedian.Text = "The median is: " + median.ToString();
        }
        // Function to find max
        static int maximum(int a, int b)
        {
            return a > b ? a : b;
        }

        // Function to find minimum
        static int minimum(int a, int b)
        {
            return a < b ? a : b;
        }

        // Function to find median of two sorted
        // arrays
        static double findMedianSortedArrays(ref int[] a, int n,
                                             ref int[] b, int m)
        {

            int min_index = 0, max_index = n, i = 0, j = 0,
                median = 0;

            while (min_index <= max_index)
            {
                i = (min_index + max_index) / 2;
                j = ((n + m + 1) / 2) - i;

                // if i = n, it means that Elements
                // from a[] in the second half is an
                // empty set. and if j = 0, it means
                // that Elements from b[] in the first
                // half is an empty set. so it is
                // necessary to check that, because we
                // compare elements from these two
                // groups. Searching on right
                if (i < n && j > 0 && b[j - 1] > a[i])
                    min_index = i + 1;

                // if i = 0, it means that Elements
                // from a[] in the first half is an
                // empty set and if j = m, it means
                // that Elements from b[] in the second
                // half is an empty set. so it is
                // necessary to check that, because
                // we compare elements from these two
                // groups. searching on left
                else if (i > 0 && j < m && b[j] < a[i - 1])
                    max_index = i - 1;

                // we have found the desired halves.
                else
                {
                    // this condition happens when we
                    // don't have any elements in the
                    // first half from a[] so we
                    // returning the last element in
                    // b[] from the first half.
                    if (i == 0)
                        median = b[j - 1];

                    // and this condition happens when
                    // we don't have any elements in the
                    // first half from b[] so we
                    // returning the last element in
                    // a[] from the first half.
                    else if (j == 0)
                        median = a[i - 1];
                    else
                        median = maximum(a[i - 1], b[j - 1]);
                    break;
                }
            }

            // calculating the median.
            // If number of elements is odd
            // there is one middle element.
            if ((n + m) % 2 == 1)
                return (double)median;

            // Elements from a[] in the second
            // half is an empty set.
            if (i == n)
                return (median + b[j]) / 2.0;

            // Elements from b[] in the second
            // half is an empty set.
            if (j == m)
                return (median + a[i]) / 2.0;

            return (median + minimum(a[i], b[j])) / 2.0;
            // This code is contributed by Manish Shaw
            // (manishshaw1)

        }
    }
}