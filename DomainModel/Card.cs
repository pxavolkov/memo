﻿using System;
using System.Runtime.Serialization;
using MongoDB.Bson;
using MongoRepository;

namespace SuperMemo.DomainModel
{

    public enum Score
    {
        None = 0,
        Hard = 3,
        Medium = 4,
        Easy = 5
    }

    public class Card : Entity
    {
        public string Word { get; set; }
        public string Translation { get; set; }
        public DateTime? LastTrainingDate { get; set; }
        public Score Score { get; set; }
        public DateTime NextDate { get; set; }
        public double EFactor { get; set; }
        public int LastInterval { get; set; }
        public int NumberOfRepetitions { get; set; }
        public User Owner { get; set; }

        public Card()
        {
        }

        public Card(string word, string translation)
        {
            Word = word;
            Translation = translation;
        }
    }
}
