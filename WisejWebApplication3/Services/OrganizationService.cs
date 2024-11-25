﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace WisejWebApplication3.Services
{
    public class OrganizationService
    {
        public static async Task<List<Organization>> GetOrganizations()
        {
            using (var context = new MyDbContext())
            {
                return await context.Organizations.ToListAsync();
            }
        }

        public static async Task AddOrganization(Organization organization)
        {
            using (var context = new MyDbContext())
            {
                context.Organizations.Add(organization);
                await context.SaveChangesAsync();
            }
        }

        public static async Task RemoveOrganization(int id)
        {
            using (var context = new MyDbContext())
            {
                Organization organization = await context.Organizations.FindAsync(id);
                if (organization == null)
                {
                    throw new ArgumentException($"Could not remove organization. Organization with ID {id} not found");
                }
                context.Organizations.Remove(organization);
                await context.SaveChangesAsync();
            }
        }

        public static async Task EditOrganization(int id, Organization updatedOrganization)
        {
            using (var context = new MyDbContext())
            {
                Organization organization = await context.Organizations.FindAsync(id);
                if (organization == null)
                {
                    throw new ArgumentException($"Could not edit organization. Organization with ID {id} not found");
                }
                context.Entry(organization).CurrentValues.SetValues(updatedOrganization);
                await context.SaveChangesAsync();
            }
        }

    }
}