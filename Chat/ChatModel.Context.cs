﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chat.BU
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChatModelContainer : DbContext
    {
        public ChatModelContainer()
            : base("name=ChatModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Message> MessageSet { get; set; }
        public virtual DbSet<Chat> ChatSet { get; set; }
        public virtual DbSet<User> UserSet { get; set; }
        public virtual DbSet<FriendList> FriendListSet { get; set; }
    }
}