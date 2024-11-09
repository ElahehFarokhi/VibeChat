using System;
using System.Collections.Generic;
using System.Linq;

namespace VibeChat.Api.Services
{
    public class ChatService
    {
        //key, value eg: { {"John","John's ConnectionId"},{"Tom","Tom's ConnectionId"} }
        private static readonly Dictionary<string, string> Users = [];

        public ChatService()
        {

        }

        public bool AddUserToServive(string userToAdd) 
        {
            lock (Users) 
            {
                foreach (var user in Users)
                {
                    if (user.Key.Equals(userToAdd,StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                }
                Users.Add(userToAdd, null);
                return true;
            }

        }

        public void AddUserConnectionId(string user,string connectionId) 
        {
            lock (Users) 
            {
                if (Users.ContainsKey(user))
                {
                    Users[user] = connectionId;
                }
            }
        }

        public string GetUserByConnectionId(string connectionId)
        {
            lock (Users)
            {
                return Users.Where(x => x.Value == connectionId).Select(x => x.Key).FirstOrDefault();
            }
        }

        public string GetConnectionIdByUser(string user)
        {
            lock (Users)
            {
                return Users.Where(x => x.Key == user).Select(x => x.Value).FirstOrDefault();
            }
        }

        public void RemoveUserFromList(string user)
        {
            if (Users.ContainsKey(user))
            {
                Users.Remove(user);
            }
        }

        public string[] GetOnlineUser()
        {
            lock (Users)
            {
                return Users.OrderBy(x => x.Key).Select(x => x.Key).ToArray();
            }
        }

    }
}
