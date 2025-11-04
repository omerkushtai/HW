using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Threading; // נדרש עבור משימה 3
namespace piano;
public class Program
{
    //
    // =============================================
    // ========== תוכנית ראשית - לא לגעת! ==========
    // =============================================
    public static void Main(string[] args)
    {

        Console.WriteLine("--- Mission 1: SocialApp (User Class Test) ---");
        RunMission1();

        Console.WriteLine("\n--- Mission 2: High Scores ---");
        RunMission2();

        Console.WriteLine("\n--- Mission 3: Console Piano ---");
        RunMission3();

        Console.WriteLine("\n--- Challenge Mission: Spam Filter ---");
        RunChallengeMission();
    }

    // =============================================
    // ========== משימה 1 - בודק אוטומטי ==========
    // =============================================
    public static void RunMission1()
    {
        // קוד זה בודק את מחלקת User שיצרתם בקובץ User.cs
        // 1. יצירת משתמשים ומילון
        var allUsers = new Dictionary<string, User>();

        User alice = new User("Alice");
        User bob = new User("Bob");
        User charlie = new User("Charlie");

        allUsers.Add(alice.Username, alice);
        allUsers.Add(bob.Username, bob);
        allUsers.Add(charlie.Username, charlie);

        // 2. בדיקת הוספה
        Console.WriteLine("Testing AddFriend:");
        alice.AddFriend("Bob");
        alice.AddFriend("Charlie");
        bob.AddFriend("Alice");

        // 3. בדיקת כפילות
        Console.WriteLine("\nTesting duplicate AddFriend (should fail silently or return false):");
        bool result = alice.AddFriend("Bob");
        Console.WriteLine($"Adding Bob again returned: {result}");

        // 4. בדיקת הדפסה
        Console.WriteLine("\nTesting PrintFriends:");
        alice.PrintFriends();
        bob.PrintFriends();

        // 5. בדיקת מחיקה
        Console.WriteLine("\nTesting RemoveFriend:");
        alice.RemoveFriend("Charlie");
        alice.PrintFriends();
    }


    // =============================================
    // ========== משימה 2 - מקום למילוי ==========
    // =============================================
    public static void RunMission2()
    {
        // TODO: כתבו כאן את הקוד שלכם למשימה 2
        // צרו מילון, הוסיפו ערכים, עדכנו, בדקו בבטחה, סרקו והדפיסו

        Console.WriteLine("RunMission2() is not implemented yet.");
    }

    // =============================================
    // ========== משימה 3 - מקום למילוי ==========
    // =============================================


    public static void RunMission3()
    {
        // TODO: כתבו כאן את הקוד שלכם למשימה 3
        // צרו מילון תדרים, רשימת שיר, קראו לפעולת PLAY
        // 

        Console.WriteLine("RunMission3() is not implemented yet.");
        // Play(,) //יש לקרוא לפעולת הPlay

    }
    public static void Play(Dictionary<string, int> notes, List<string> song)
    {
        //רמז: השתמשו ב-Console.Beep(frequency, duration);

        int noteDuration = 300;//משך של כל צליל
                               // דוגמה לשימוש בצליל (אפשר למחוק):
                               // Console.Beep(440, noteDuration); // מנגן את התו "A" לשנייה 
                               //למשך 300 מילישניות

        //על מנת לייצר הפסקה (REST) בנגינה :
        //if (התו == "R")
        //{
        //				Thread.Sleep(restDuration);
        //Thread.Sleep(int  duration)- פעולה הגורמת לתוכנית להכנס למצב המתנה למספר המילישניות שהתקבלו בפרמטר

        //}

    }
    // =============================================
    // ========== משימת אתגר - מקום למילוי ==========
    // =============================================

    public static void RunChallengeMission()
    {
        List<string> comments = new List<string>();
        comments.Add("What a great article");
        comments.Add("Buy Bitcoin now");
        comments.Add("This really helped me, thanks");
        comments.Add("Amazing offer just for you");
        comments.Add("How do I sign up?");
        int cnt = 0;
        foreach (var comment in comments)
        {
            cnt++;
            if (comment.Contains("Bitcoin") || comment.Contains("offer"))
            {
                comments.RemoveAt(cnt);
            }
        }
        Console.WriteLine("filtered comments"+comments);
    }
}

