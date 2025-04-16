using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Jurnal08;
namespace Jurnal08
{
    public class Transfer {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee  { get; set; }
    }

    public class Confirmation {
        public string en { get; set; }
        public string id { get; set; }
    }
    public class BankTransferConfig
    {
        public Confirmation confirmation { get; set; }
        public string lang  { get; set; } ="en"; 
        public Transfer transfer { get; set; }
        public List<String> methods { get; set; }
        string filePath = @"bank_transfer_config.json";
        public BankTransferConfig config;
            public void ReadJSON()
            {
            //String configJsonData = File.ReadAllText(filePath);
            //BankTransferConfig config = JsonSerializer.Deserialize<BankTransferConfig>(configJsonData);
            //return config            
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                BankTransferConfig x = JsonSerializer.Deserialize<BankTransferConfig>(json);
                lang = x.lang;
                transfer.threshold = x.transfer.threshold;
                transfer.low_fee = x.transfer.low_fee;
                transfer.high_fee = x.transfer.high_fee;
                for (int i = 0; i < x.methods.Count; i++)
                {
                    methods[i] = x.methods[i];
                }
                confirmation.en = x.confirmation.en;
                confirmation.id = x.confirmation.id;
            }

        }
          
        }
    }

