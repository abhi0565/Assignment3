using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using AssignmentSample.Models;


namespace AssignmentSample.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AssignmentSampleContentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AssignmentSampleContentContext>>()))
            {
                // Look for any foods.
                if (context.Content.Any())
                {
                    return;   // DB has been seeded
                }

                context.Content.AddRange(
                    new Content
                    {
                        Title = "siro",
                        Type = "sweet",
                        Body = "sweet",
                        Tag = "gujarat",
                        ImgUrl = "123"
                    },

                    new Content
                    {
                        Title = "pavbhaji ",
                        Type = "sabji",
                        Body = "spicy",
                        Tag = "mumbai",
                         ImgUrl = "123"
                    },

                    new Content
                    {
                        Title = "khamna",
                        Type = "snaks",
                        Body = "mix",
                        Tag = "gujarat",
                         ImgUrl = "123"
                    },

                    new Content
                    {
                        Title = "dhokda",
                        Type = "farsan",
                        Body = "spicy",
                        Tag = "gujarat",
                         ImgUrl = "123"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}