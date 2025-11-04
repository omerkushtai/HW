using System;

namespace piano;

public class User
{
    public string Username { get; set; }
    public List<string> Friends
    {
        get; private set;
    }
    public User(string username)
    {
        Username = username;
        Friends = new List<string>();
    }

    public bool AddFriend(string friendName)
    {
        if (Friends.Count != 0 && !Friends.Contains(friendName))
        {
            Friends.Add(friendName);
            Console.WriteLine($"{friendName} succefully added to friends list.{Username}");
            return true;
        }
        else
        {
            return false;
        }

    }
    public bool RemoveFriend(string friendName)
    {
        if (Friends.Count != 0 && Friends.Remove(friendName))
        {
            
            Console.WriteLine($"{friendName} succefully removed from friends list.");
            return true;
        }
            return false;
    }
    public void PrintFriends()
    {
        Console.WriteLine("the friends of " + Username + " are:");
        foreach (var friend in Friends)
        {
            Console.WriteLine(friend);
        }
    }

     public Dictionary<string, List<string>> GetFriendsOfFriends(Dictionary<string, User> network)
    {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
        foreach (var friendName in Friends)
        {
            if (network.ContainsKey(friendName))
            {
                result.Add(friendName, network[friendName].Friends);

            }

        }
        return result;
        
        
    }
    


}
