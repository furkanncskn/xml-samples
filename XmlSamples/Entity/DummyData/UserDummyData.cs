using System;
using System.Collections.Generic;

namespace XmlSamples.Entity.DummyData
{
    public static class UserDummyData
    {
        public static User[] users = new Entity.User[]
        {
            new User()
            {
                USER_ID = 11234,
                USER_NAME = "Test1",
                USER_EMAIL = "testing@gmail.com",
                USER_PASSWORD = "123456",
                USER_REGISTER_DATE = DateTime.Now,
                USER_IS_ACTIVE = true
            },

            new User()
            {
                USER_ID = 11235,
                USER_NAME = "Test2",
                USER_EMAIL = "testing2@gmail.com",
                USER_PASSWORD = "654321",
                USER_REGISTER_DATE = DateTime.Now,
                USER_IS_ACTIVE = true
            }
        };

        public static List<User> listUsers = new List<User>()
        {
            new User()
            {
                USER_ID = 11234,
                USER_NAME = "Test1",
                USER_EMAIL = "testing@gmail.com",
                USER_PASSWORD = "123456",
                USER_REGISTER_DATE = DateTime.Now,
                USER_IS_ACTIVE = true
            },

            new User()
            {
                USER_ID = 11235,
                USER_NAME = "Test2",
                USER_EMAIL = "testing2@gmail.com",
                USER_PASSWORD = "654321",
                USER_REGISTER_DATE = DateTime.Now,
                USER_IS_ACTIVE = true
            }
        };
    }
}
