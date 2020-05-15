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
            Console.WriteLine("-----Initialize Test Data-----");
            TestData.Init();
            process.AddUsers(TestData.GetUsers());
            process.AddVideos(TestData.GetVideos());
            process.AddComments(TestData.GetComments());


            MainProcessing process1 = new MainProcessing();
            Console.WriteLine("-----Show titles of all videos-----");
            Display(process1.GetTitleOfAllVideo());
            Console.WriteLine();
            Console.WriteLine($"Show titles of all video which author by user: 'TrangUyen'");
            Display(process1.GetTitleOfvideosAuthorByUserName("TrangUyen"));
            Console.WriteLine();
            Console.WriteLine($"Show tiltes of all video which authored by user: 'TrangUyen' that user: 'Phobovien' comment: ");
            Display(process1.GetTitleOfVideosAuthorByUserOneThatUserTwoComment_ByName("TrangUyen", "Phobovien"));
            Console.WriteLine();
            Console.WriteLine($"Show tiltes of all video received comments during the last week: ");
            Display(process1.GetTitleOfVideosReceivedCommentLastWeek());
            Console.WriteLine();
            Console.WriteLine($"Show tiltes of video received the most comments: ");
            var result = process1.GetVideoReceivedTheMostComment();
            

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
