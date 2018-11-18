using System;
using System.Collections.Generic;

namespace FilmLibraryApp.Common
{
    public static class Mediator
    {
        private static IDictionary<string, ICollection<Action<object>>> navigationDictionary =
           new Dictionary<string, ICollection<Action<object>>>();

        public static void Subscribe(string token, Action<object> callback)
        {
            if (!navigationDictionary.ContainsKey(token))
            {
                var callbackCollection = new List<Action<object>>();
                callbackCollection.Add(callback);
                navigationDictionary.Add(token, callbackCollection);
            }
            else
            {
                bool found = false;
                foreach (var item in navigationDictionary[token])
                {
                    if (item.Method.ToString() == callback.Method.ToString())
                    {
                        found = true;
                    }                        
                }
                if (!found)
                {
                    navigationDictionary[token].Add(callback);
                }
                    
            }
        }

        public static void Unsubscribe(string token, Action<object> callback)
        {
            if (navigationDictionary.ContainsKey(token))
            {
                navigationDictionary[token].Remove(callback);
            }
        }

        public static void Notify(string token, object args = null)
        {
            if (navigationDictionary.ContainsKey(token))
            {
                foreach (var callback in navigationDictionary[token])
                {
                    callback(args);
                }
            }
        }
    }
}
