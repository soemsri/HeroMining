﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMining.ApplicationCore.Pool
{
    public class ZpoolAPI
    {
        /// <summary>
        /// Load coin mining data from zpool.ca
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">Get data from zpool.ca web api failed.</exception>
        public CryptoCurrency LoadCurrency()
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    // HTTP POST
                    client.BaseAddress = new Uri("https://www.zpool.ca");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.GetAsync("/api/currencies").Result;
                    string res = "";
                    using (HttpContent content = response.Content)
                    {
                        // ... Read the string.
                        Task<string> result = content.ReadAsStringAsync();
                        res = result.Result;
                        res = res.Replace("24h_blocks", "h24_blocks").Replace("24h_btc", "h24_btc");
                        CryptoCurrency coins = JsonConvert.DeserializeObject<CryptoCurrency>(res);
                        return coins;
                    }
                }
            }
            catch (Exception err)
            {
                throw new Exception("Get data from zpool.ca web api failed.", err);
            }
        }


        /// <summary>
        /// Load algorithm status from zpool.ca
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">Get data from zpool.ca web api failed.</exception>
        public Algorithm LoadAlgorithm()
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {
                    // HTTP POST
                    client.BaseAddress = new Uri("https://www.zpool.ca");
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.GetAsync("/api/status").Result;
                    string res = "";
                    using (HttpContent content = response.Content)
                    {
                        // ... Read the string.
                        Task<string> result = content.ReadAsStringAsync();
                        res = result.Result;
                        res = res.Replace("argon2d-dyn", "argon2d_dyn").Replace("myr-gr", "myr_gr");
                        Algorithm algor = JsonConvert.DeserializeObject<Algorithm>(res);
                        return algor;
                    }
                }
            }
            catch (Exception err)
            {
                throw new Exception("Get algorithm status from zpool.ca web api failed. [https://www.zpool.ca/api/status]", err);
            }
        }
    }
}
