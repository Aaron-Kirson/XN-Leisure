using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace XN_Leisure.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        //can be used to calculate the result of 7 + 5
        public void OnPostSum(int A, int B)
        {
            var sum = CalculateSum(A, B);

            ViewData["sum"] = sum.ToString();
        }

        /*can be used to calculate how many letters e’s are in the following sentence ‘Lorem ipsum dolor sit amet, 
         * consectetur adipiscing elit. Eanean sodales justo et Enim ornare,
         * a congue lacus commodo.’ 
         * How many number 1s are in the following number 17272838119191929838299111 */
        public void OnPostCount(string word, char input)
        {
            var charCount = FindCharCount(word, input);

            ViewData["count"] = charCount.ToString();
        }

        public int CalculateSum(int A, int B)
        {
            var sum = A + B;

            return sum;
        }


        public int FindCharCount(string word, char input)
        {
            word = word.ToLower();
            int counter = 0;

            if (word.Contains(input))
            {
                foreach (char a in word)
                {
                    if (a == input)
                    {
                        counter++;
                    }
                }
                return counter;
            }
            else
            {
                return 0;
            }
        }
    }
}
