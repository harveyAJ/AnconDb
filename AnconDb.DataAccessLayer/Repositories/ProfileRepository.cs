﻿using AnconDb.DataAccessLayer.Entities;

namespace AnconDb.DataAccessLayer.Repositories
{
    public class ProfileRepository : RepositoryBase<Profile>
    {
        public ProfileRepository(ProfileDbContext context)
            : base(context)
        {

        }

    }
}
