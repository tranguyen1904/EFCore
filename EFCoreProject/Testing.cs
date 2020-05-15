using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class Testing
    {
        public void Test()
        {
            MainProcessing process = new MainProcessing();
            TestData.Init();
            process.AddUsers(TestData.GetUsers());
            process.AddVideos(TestData.GetVideos());
            process.AddComments(TestData.GetComments());
            MainProcessing process1 = new MainProcessing();
            Display(process1.GetTitleOfAllVideo());
            Console.WriteLine();
            Display(process1.GetTitleOfvideosAuthorByUserName("TrangUyen"));
            Console.WriteLine();
            Display(process1.GetTitleOfVideosAuthorByUserOneThatUserTwoComment_ByName("TrangUyen", "Phobovien"));
        }

        private void Display(IEnumerable<string> listString)
        {
            foreach(string item in listString)
            {
                Console.WriteLine(item);
            }
        }
    }
}
