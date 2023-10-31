﻿// <auto-generated />
using System;
using DiscordBot.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiscordBot.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("DiscordBot.Db.Entity.GuildSetting", b =>
                {
                    b.Property<ulong>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("DailyEffectChannelId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("DailyEffectMessageId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("ErinnTimeChannelId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("ErinnTimeMessageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GuildId");

                    b.ToTable("GuildSettings");
                });
#pragma warning restore 612, 618
        }
    }
}
