using Larpchive_Of_Our_Own;
using ApiInterface;
namespace Test
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ApiService a = new ApiService();
            #region tags
            //Console.WriteLine($"======Get======");
            //TagList t = await a.GetAllTags();
            //foreach (Tags tag in t)
            //{
            //    await Console.Out.WriteLineAsync(tag.Tagname);
            //}
            //t = await a.GetAllTags();
            //Console.WriteLine($"======Post======");
            //Tags t1 = new Tags() { Tagname = "magic" };
            //await a.InsertTag(t1);
            //t = await a.GetAllTags();
            //await Console.Out.WriteLineAsync(t.MaxBy(x => x.Id).Tagname);
            //Console.WriteLine($"======Put======");
            //Tags myTags = t.MaxBy(x => x.Id);
            //myTags.Tagname = "Magic";
            //await a.UpdateTag(myTags);
            //t = await a.GetAllTags();
            //await Console.Out.WriteLineAsync(t.MaxBy(x => x.Id).Tagname);
            //Console.WriteLine($"======Delete======");
            //Console.WriteLine(t.Count);
            //int id = t.MaxBy(x => x.Id).Id;
            //await a.DeleteTag(id);
            //t = await a.GetAllTags();
            //Console.WriteLine(t.Count);
            #endregion
            #region AgeRating
            //Console.WriteLine($"======Get======");
            //AgeRatingList ar = await a.GetAllAgeRating();
            //foreach (AgeRating ageRating in ar)
            //{
            //    await Console.Out.WriteLineAsync(ageRating.Age_Rating);
            //}

            //ar = await a.GetAllAgeRating();
            //Console.WriteLine($"======Post======");
            //AgeRating ar1 = new AgeRating() { Age_Rating = "family friendly" };
            //await a.InsertAgeRating(ar1);
            //ar = await a.GetAllAgeRating();
            //await Console.Out.WriteLineAsync(ar.MaxBy(x => x.Id).Age_Rating);

            //Console.WriteLine($"======Put======");
            //AgeRating myAR = ar.MaxBy(x => x.Id);
            //myAR.Age_Rating = "Family Friendly";
            //await a.UpdateAgeRating(myAR);
            //ar = await a.GetAllAgeRating();
            //await Console.Out.WriteLineAsync(ar.MaxBy(x => x.Id).Age_Rating);

            //Console.WriteLine($"======Delete======");
            //Console.WriteLine(ar.Count);
            //int arid = ar.MaxBy(x => x.Id).Id;
            //await a.DeleteAgeRating(arid);
            //ar = await a.GetAllAgeRating();
            //Console.WriteLine(ar.Count);
            #endregion
            #region Privacy
            //Console.WriteLine($"======Get======");
            //PrivacyList p = await a.GetAllPrivacy();
            //foreach (Privacy privacy in p)
            //{
            //    await Console.Out.WriteLineAsync(privacy.PrivacyLevel);
            //}

            //p = await a.GetAllPrivacy();
            //Console.WriteLine($"======Post======");
            //Privacy p1 = new Privacy() { PrivacyLevel = "link only" };
            //await a.InsertPrivacy(p1);
            //p = await a.GetAllPrivacy();
            //await Console.Out.WriteLineAsync(p.MaxBy(x => x.Id).PrivacyLevel);

            //Console.WriteLine($"======Put======");
            //Privacy myP = p.MaxBy(x => x.Id);
            //myP.PrivacyLevel = "Link Only";
            //await a.UpdatePrivacy(myP);
            //p = await a.GetAllPrivacy();
            //await Console.Out.WriteLineAsync(p.MaxBy(x => x.Id).PrivacyLevel);

            //Console.WriteLine($"======Delete======");
            //Console.WriteLine(p.Count);
            //int pid = p.MaxBy(x => x.Id).Id;
            //await a.DeletePrivacy(pid);
            //p = await a.GetAllPrivacy();
            //Console.WriteLine(p.Count);
            #endregion
            #region Languages
            //Console.WriteLine($"======Get======");
            //LanguageList l = await a.GetAllLanguages();
            //foreach (Languages language in l)
            //{
            //    await Console.Out.WriteLineAsync(language.LanguageNameInEnglish);
            //}
            //l = await a.GetAllLanguages();

            //Console.WriteLine($"======Post======");
            //Languages l1 = new Languages()
            //{
            //    LanguageNameInEnglish = "kinyarwanda",
            //    LanguageNameInOriginalLangauge = "",
            //    LettersInAlpabetticalOrder = ""
            //};
            //await a.InsertLanguage(l1);
            //l = await a.GetAllLanguages();
            //await Console.Out.WriteLineAsync(l.MaxBy(x => x.Id).LanguageNameInEnglish);

            //Console.WriteLine($"======Put======");
            //Languages myL = l.MaxBy(x => x.Id);
            //myL.LanguageNameInEnglish = "Kinyarwanda";
            //await a.UpdateLanguage(myL);
            //l = await a.GetAllLanguages();
            //await Console.Out.WriteLineAsync(l.MaxBy(x => x.Id).LanguageNameInEnglish);

            //Console.WriteLine($"======Delete======");
            //Console.WriteLine(l.Count);
            //int lid = l.MaxBy(x => x.Id).Id;
            //await a.DeleteLanguage(lid);
            //l = await a.GetAllLanguages();
            //Console.WriteLine(l.Count);
            #endregion
            #region Chapters
            //Console.WriteLine($"======Get======");
            //ChapterList ch = await a.GetAllChapters();
            //foreach (Chapters chapter in ch)
            //{
            //    await Console.Out.WriteLineAsync(chapter.ChapterName);
            //}

            //ch = await a.GetAllChapters();
            //Console.WriteLine($"======Post======");
            //WorksList wch = await a.GetAllWorks();
            //Chapters ch1 = new Chapters()
            //{
            //    ChapterName = "sMalik",
            //    ChapterNum = 2,
            //    Notes = "",
            //    Story = "",
            //    Summary = "",
            //    WorkID = wch[3]
            //};
            //await a.InsertChapter(ch1);
            //ch = await a.GetAllChapters();
            //await Console.Out.WriteLineAsync(ch.MaxBy(x => x.Id).ChapterName);

            //Console.WriteLine($"======Put======");
            //Chapters myCH = ch.MaxBy(x => x.Id);
            //myCH.ChapterName = "Smolik";
            //await a.UpdateChapter(myCH);
            //ch = await a.GetAllChapters();
            //await Console.Out.WriteLineAsync(ch.MaxBy(x => x.Id).ChapterName);

            //Console.WriteLine($"======Delete======");
            //Console.WriteLine(ch.Count);
            //int chid = ch.MaxBy(x => x.Id).Id;
            //await a.DeleteChapter(chid);
            //ch = await a.GetAllChapters();
            //Console.WriteLine(ch.Count);
            #endregion
            #region Comments
            //Console.WriteLine($"======Get======");
            //CommentList c = await a.GetAllComments();
            //foreach (Comments comment in c)
            //{
            //    await Console.Out.WriteLineAsync(comment.Comment);
            //}

            //c = await a.GetAllComments();
            //Console.WriteLine($"======Post======");
            //WorksList wc = await a.GetAllWorks();
            //UserList uc = await a.GetAllUsers();
            //Comments c1 = new Comments()
            //{
            //    Comment = "blablabla",
            //    UserId = uc[3],
            //    WorkId = wc[2],
            //    DateOfComment = new DateTime(2005, 5, 25),
            //    Rating = 5
            //};
            //await a.InsertComment(c1);
            //c = await a.GetAllComments();
            //await Console.Out.WriteLineAsync(c.MaxBy(x => x.Id).Comment);

            //Console.WriteLine($"======Put======");
            //Comments myC = c.MaxBy(x => x.Id);
            //myC.Comment = "Bla Bla Bla";
            //await a.UpdateComment(myC);
            //c = await a.GetAllComments();
            //await Console.Out.WriteLineAsync(c.MaxBy(x => x.Id).Comment);

            //Console.WriteLine($"======Delete======");
            //Console.WriteLine(c.Count);
            //int cid = c.MaxBy(x => x.Id).Id;
            //await a.DeleteComment(cid);
            //c = await a.GetAllComments();
            //Console.WriteLine(c.Count);
            #endregion
            #region Users
            //Console.WriteLine($"======Get======");
            //UserList u = await a.GetAllUsers();
            //foreach (Users user in u)
            //{
            //    await Console.Out.WriteLineAsync(user.Username);
            //}

            //u = await a.GetAllUsers();
            //Console.WriteLine($"======Post======");
            //Users u1 = new Users()
            //{
            //    Email = "mikehawk@gmail.com",
            //    Username = "mike",
            //    DateOfCreation = new DateTime(2020, 2, 14)
            //};
            //await a.InsertUser(u1);
            //u = await a.GetAllUsers();
            //await Console.Out.WriteLineAsync(u.MaxBy(x => x.Id).Username);

            //Console.WriteLine($"======Put======");
            //Users myU = u.MaxBy(x => x.Id);
            //myU.Username = "Mike";
            //await a.UpdateUser(myU);
            //u = await a.GetAllUsers();
            //await Console.Out.WriteLineAsync(u.MaxBy(x => x.Id).Username);

            //Console.WriteLine($"======Delete======");
            //Console.WriteLine(u.Count);
            //int uid = u.MaxBy(x => x.Id).Id;
            //await a.DeleteUser(uid);
            //u = await a.GetAllUsers();
            //Console.WriteLine(u.Count);
            #endregion
            #region Works
            //Console.WriteLine($"======Get======");
            //WorksList w = await a.GetAllWorks();
            //foreach (Works work in w)
            //{
            //    await Console.Out.WriteLineAsync(work.WorkName);
            //}

            //w = await a.GetAllWorks();
            //Console.WriteLine($"======Post======");
            //LanguageList WlList = await a.GetAllLanguages();
            //UserList WuList = await a.GetAllUsers();
            //PrivacyList WpList = await a.GetAllPrivacy();
            //AgeRatingList WarList = await a.GetAllAgeRating();

            //Works w1 = new Works()
            //{
            //    WorkName = "slimki",
            //    Description = "shlomki is an edghoge",
            //    ChapterGoal = "69",
            //    Language = WlList[2],
            //    Author = WuList[5],
            //    DateOfRelease = new DateTime(2007, 3, 5),
            //    Privacy = WpList[0],
            //    AgeRating = WarList[2]
            //};

            //await a.InsertWork(w1);
            //w = await a.GetAllWorks();
            //await Console.Out.WriteLineAsync(w.MaxBy(x => x.Id).WorkName);

            //Console.WriteLine($"======Put======");
            //Works myW = w.MaxBy(x => x.Id);
            //myW.WorkName = "Slomki";
            //await a.UpdateWork(myW);
            //w = await a.GetAllWorks();
            //await Console.Out.WriteLineAsync(w.MaxBy(x => x.Id).WorkName);

            //Console.WriteLine($"======Delete======");
            //Console.WriteLine(w.Count);
            //int wid = w.MaxBy(x => x.Id).Id;
            //await a.DeleteWork(wid);
            //w = await a.GetAllWorks();
            //Console.WriteLine(w.Count);
            #endregion
            #region Tags_On_Works
            //Console.WriteLine($"======Get======");
            //Tags_On_WorksList tow = await a.GetAllTags_On_Works();
            //foreach (Tags_On_Works tagOnWork in tow)
            //{
            //    await Console.Out.WriteLineAsync(tagOnWork.WorkTags.Tagname);
            //}

            //tow = await a.GetAllTags_On_Works();
            //Console.WriteLine($"======Post======");

            //WorksList wList = await a.GetAllWorks();
            //TagList tList = await a.GetAllTags();

            //Tags_On_Works tow1 = new Tags_On_Works()
            //{
            //    WorkId = wList[4],
            //    WorkTags = tList[4]
            //};

            //await a.InsertTag_On_Works(tow1);
            //tow = await a.GetAllTags_On_Works();
            //await Console.Out.WriteLineAsync(tow.MaxBy(x => x.Id).WorkTags.Tagname);

            //Console.WriteLine($"======Put======");
            //Tags_On_Works myTOW = tow.MaxBy(x => x.Id);
            //myTOW.WorkTags = tList[5];
            //await a.UpdateTags_On_Works(myTOW);
            //tow = await a.GetAllTags_On_Works();
            //await Console.Out.WriteLineAsync(tow.MaxBy(x => x.Id).WorkTags.Tagname);

            //Console.WriteLine($"======Delete======");
            //Console.WriteLine(tow.Count);
            //int towid = tow.MaxBy(x => x.Id).Id;
            //await a.DeleteTags_On_Works(towid);
            //tow = await a.GetAllTags_On_Works();
            //Console.WriteLine(tow.Count);
            #endregion
            #region Admin
            //Console.WriteLine($"======Get======");
            //AdminList ad = await a.GetAllAdmins();
            //foreach (Admin admin in ad)
            //{
            //    await Console.Out.WriteLineAsync(
            //        $"{admin.Email}, {admin.Username}, {admin.DateOfCreation}, {admin.IsVerified}");
            //}
            //ad = await a.GetAllAdmins();

            //Console.WriteLine($"======Post======");
            //Admin ad1 = new Admin()
            //{
            //    Id = 13,
            //    Email = "RandomKid@gmail.com",
            //    Username = "Sunna",
            //    DateOfCreation = new DateTime(2018, 12, 5),
            //    IsVerified = true
            //};

            //await a.InsertAdmin(ad1);
            //ad = await a.GetAllAdmins();
            //Admin latestAdmin = ad.MaxBy(x => x.Id);
            //await Console.Out.WriteLineAsync($"{latestAdmin.Email}, {latestAdmin.Username}, {latestAdmin.DateOfCreation}, {latestAdmin.IsVerified}");

            //Console.WriteLine($"======Put======");
            //ad = await a.GetAllAdmins();
            //Admin myAdmin = ad.MaxBy(x => x.Id);
            //int adminId = myAdmin.Id;
            //myAdmin.Username = "Random kid";
            //int updated = await a.UpdateAdmin(myAdmin);
            //Console.WriteLine($"{updated} rows were updated");
            //ad = await a.GetAllAdmins();
            //Admin updatedAdmin = ad.FirstOrDefault(x => x.Id == adminId);
            //latestAdmin = ad.MaxBy(x => x.Id);
            //await Console.Out.WriteLineAsync($"{latestAdmin.Email}, {latestAdmin.Username}, {latestAdmin.DateOfCreation}, {latestAdmin.IsVerified}");

            //Console.WriteLine($"======Delete======");
            //Console.WriteLine(ad.Count);
            //int adid = ad.MaxBy(x => x.Id).Id;
            //await a.DeleteAdmin(adid);
            //ad = await a.GetAllAdmins();
            //Console.WriteLine(ad.Count);
            #endregion
        }
    }
}
