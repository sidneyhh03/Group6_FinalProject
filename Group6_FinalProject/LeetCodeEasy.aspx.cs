using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Group6_FinalProject.LeetCodeMedium.MediumLeetCodeProblem;

/*
 * Name: Sidney Huschart
 * email: huschash@mail.uc.edu
 * Assignment Title: Final Project
 * Due Date: April 23 2024 7:00AM
 * Course: IS 3050
 * Semester/Year: Spring 2024
 * Brief Description: This is the easy leetcode problem. 
 * Citations: My dad's brain; https://leetcode.com/problems/single-number/description/; https://chat.openai.com/
 * Anything else that's relevant:
 */

namespace Group6_FinalProject
{
    public partial class LeetCodeEasy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] nums = { 2, 2, 1 }; // Example input array
            Solution solution = new Solution();
            int singleNumber = solution.SingleNumber(nums);
            InputLabel.Text = "Input: " + string.Join(", ", nums);
            ResultLabel.Text = "Single Number: " + singleNumber.ToString();
        }
        public class Solution
        {
            public int SingleNumber(int[] nums)
            {

                int k = 0;
                if (nums.Length == 0)
                {
                    return 0;
                }
                else if (nums.Length == 1)
                {
                    return nums[0];
                }
                else
                {
                    for (int i = 1; i < nums.Length; i++)
                    {

                        if (nums[k] == nums[i])
                        {
                            int temp = nums[k + 1];
                            nums[k + 1] = nums[i];
                            nums[i] = temp;
                            k = k + 2;
                            i = k;
                        }


                    }
                }


                return nums[k];
            }

        }
    }
}