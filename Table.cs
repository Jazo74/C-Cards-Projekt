﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cardgame
{
    class Table
    {
        Dictionary<string, Card> TableDict = new Dictionary<string, Card>();

        public void PutTable(string playername, Card card)
        {
            TableDict.Add(playername, card)
        }
        public string GetWinner(string parameter)
        {
            string winner = "error";
            float best = 0;

            foreach (KeyValuePair<string, Card> item in TableDict)
            {
                if (item.Value.paramDict[parameter] > best)
                {
                    best = item.Value.paramDict[parameter];
                    winner = item.Key;
                }


            }
            return winner;

        }
        public Dictionary<string, Card> GetTable()
        {
            return TableDict;
        }
    }
}