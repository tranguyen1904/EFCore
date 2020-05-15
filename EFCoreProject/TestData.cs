using EFCoreProject.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public static class TestData
    {
        public static User User1;
        public static User User2;
        public static User User3;
        public static User User4;
        public static Video Video1;
        public static Video Video2;
        public static Video Video3;
        public static Video Video4;
        public static Video Video5;
        public static Video Video6;
        public static Video Video7;
        public static Video Video8;
        public static Video Video9;
        public static Video Video10;
        public static Comment Comment1;
        public static Comment Comment2;
        public static Comment Comment3;
        public static Comment Comment4;
        public static Comment Comment5;
        public static Comment Comment6;
        public static Comment Comment7;
        public static Comment Comment8;
        public static Comment Comment9;
        public static Comment Comment10;
        public static Comment Comment11;
        public static Comment Comment12;
        public static Comment Comment13;
        public static Comment Comment14;
        public static Comment Comment15;
        public static Comment Comment16;
        public static Comment Comment17;
        public static Comment Comment18;
        public static Comment Comment19;
        public static Comment Comment20;

        public static void Init()
        {
            User1 = new User() { Id = Guid.NewGuid(), Nickname = "TrangUyen", Mail = "tranguyen1904@gmail.com" };
            User2 = new User() { Id = Guid.NewGuid(), Nickname = "Phobovien", Mail = "phobovien25@gmail.com" };
            User3 = new User() { Id = Guid.NewGuid(), Nickname = "AIGiveAway", Mail = "aigiveaway97@gmail.com" };
            User4 = new User() { Id = Guid.NewGuid(), Nickname = "Kraigeki", Mail = "kraigeki@gmail.com" };

            Video1 = new Video() { Id = Guid.NewGuid(), Title = "Luon xao sa ot", Quality = Video.VideoQuality.HD, UserId=User1.Id };
            Video2 = new Video() { Id = Guid.NewGuid(), Title = "Ca dieu hong nau mang chua", Quality = Video.VideoQuality.SD, UserId = User1.Id };
            Video3 = new Video() { Id = Guid.NewGuid(), Title = "Com tam suon trung", Quality = Video.VideoQuality.HD, UserId = User1.Id };
            Video4 = new Video() { Id = Guid.NewGuid(), Title = "Ca tre chien mam gung", Quality = Video.VideoQuality.HD, UserId = User2.Id };
            Video5 = new Video() { Id = Guid.NewGuid(), Title = "Dau hu nhoi thit chien sot ca", Quality = Video.VideoQuality.HD, UserId = User2.Id };
            Video6 = new Video() { Id = Guid.NewGuid(), Title = "Hu tien suon non", Quality = Video.VideoQuality.HD, UserId = User2.Id };
            Video7 = new Video() { Id = Guid.NewGuid(), Title = "Hu tieu tom thit", Quality = Video.VideoQuality.HD, UserId = User3.Id };
            Video8 = new Video() { Id = Guid.NewGuid(), Title = "Mi tom thit", Quality = Video.VideoQuality.HD, UserId = User3.Id };
            Video9 = new Video() { Id = Guid.NewGuid(), Title = "Mi hai san", Quality = Video.VideoQuality.HD, UserId = User4.Id };
            Video10 = new Video() { Id = Guid.NewGuid(), Title = "Com chien duong chau", Quality = Video.VideoQuality.HD, UserId = User4.Id };

            Comment1 = new Comment() { Id = Guid.NewGuid(), UserId = User1.Id, VideoId = Video1.Id, Time = DateTime.Now.AddDays(-10) };
            Comment2 = new Comment() { Id = Guid.NewGuid(), UserId = User2.Id, VideoId = Video2.Id, Time = DateTime.Today.AddDays(-12) };
            Comment3 = new Comment() { Id = Guid.NewGuid(), UserId = User3.Id, VideoId = Video3.Id, Time = DateTime.Today.AddDays(-1) };
            Comment4 = new Comment() { Id = Guid.NewGuid(), UserId = User4.Id, VideoId = Video4.Id, Time = DateTime.Today.AddDays(-3) };
            Comment5 = new Comment() { Id = Guid.NewGuid(), UserId = User4.Id, VideoId = Video5.Id, Time = DateTime.Today.AddDays(-3) };
            Comment6 = new Comment() { Id = Guid.NewGuid(), UserId = User3.Id, VideoId = Video3.Id, Time = DateTime.Today.AddDays(-7) };
            Comment7 = new Comment() { Id = Guid.NewGuid(), UserId = User2.Id, VideoId = Video2.Id, Time = DateTime.Today.AddDays(-2) };
            Comment8 = new Comment() { Id = Guid.NewGuid(), UserId = User1.Id, VideoId = Video1.Id, Time = DateTime.Today.AddDays(-2) };
            Comment9 = new Comment() { Id = Guid.NewGuid(), UserId = User1.Id, VideoId = Video1.Id, Time = DateTime.Today.AddDays(-6) };
            Comment10 = new Comment() { Id = Guid.NewGuid(), UserId = User3.Id, VideoId = Video2.Id, Time = DateTime.Today.AddDays(-12) };
            Comment11 = new Comment() { Id = Guid.NewGuid(), UserId = User3.Id, VideoId = Video4.Id, Time = DateTime.Today.AddDays(-8) };
            Comment12 = new Comment() { Id = Guid.NewGuid(), UserId = User2.Id, VideoId = Video5.Id, Time = DateTime.Today.AddDays(-7) };
            Comment13 = new Comment() { Id = Guid.NewGuid(), UserId = User2.Id, VideoId = Video8.Id, Time = DateTime.Today.AddDays(-5) };
            Comment14 = new Comment() { Id = Guid.NewGuid(), UserId = User4.Id, VideoId = Video9.Id, Time = DateTime.Today.AddDays(-3) };
            Comment15 = new Comment() { Id = Guid.NewGuid(), UserId = User4.Id, VideoId = Video7.Id, Time = DateTime.Today.AddDays(-2) };
            Comment16 = new Comment() { Id = Guid.NewGuid(), UserId = User1.Id, VideoId = Video4.Id, Time = DateTime.Today.AddDays(-1) };
            Comment17 = new Comment() { Id = Guid.NewGuid(), UserId = User3.Id, VideoId = Video2.Id, Time = DateTime.Today.AddDays(-8) };
            Comment18 = new Comment() { Id = Guid.NewGuid(), UserId = User2.Id, VideoId = Video3.Id, Time = DateTime.Today.AddDays(-12) };
            Comment19 = new Comment() { Id = Guid.NewGuid(), UserId = User3.Id, VideoId = Video4.Id, Time = DateTime.Today.AddDays(-3) };
            Comment20 = new Comment() { Id = Guid.NewGuid(), UserId = User1.Id, VideoId = Video6.Id, Time = DateTime.Today.AddDays(-2) };

        }

        public static User[] GetUsers()
        {
            return new User[] { User1, User2, User3, User4 };
        }

        public static Video[] GetVideos()
        {
            return new Video[] { Video1, Video2, Video3, Video4, Video5, Video6, Video7, Video8, Video9, Video10 };
        }

        public static Comment[] GetComments()
        {
            return new Comment[] 
            {
                Comment1, Comment2, Comment3, Comment4, Comment5,
                Comment6, Comment7, Comment8, Comment9, Comment10,
                Comment11, Comment12, Comment13, Comment14, Comment15,
                Comment16, Comment17, Comment18, Comment19, Comment20
            };
        }
    }
}
