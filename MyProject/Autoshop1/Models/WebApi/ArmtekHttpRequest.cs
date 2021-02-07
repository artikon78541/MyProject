using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Autoshop1.Models.MainModels;
using Autoshop1.Models.Repositories;
using System.Globalization;

namespace Autoshop1.Models.WebApi
{
    public class HttpReq
    {

        public HttpReq(string request)
        {
            values.Clear();
            values.Add("PIN", request);
            values.Add("VKORG", "5110");
            values.Add("KUNNR_RG", "43146141");
        }

        public static string urlString = "http://ws.armtek.ru/api/ws_search/search?format=json";
        public static string user_login = "autocom8@mail.ru";
        public static string user_password = "autocom8";
        public static Dictionary<string, string> values = new Dictionary<string, string>
        {

        };


        public async Task<List<SearchPart>> GetResponse()
        {
            HttpResponseMessage response = null;
            string jsonResult;
            List<SearchPart> parts = new List<SearchPart>();
            //using (var httpClient = new HttpClient())
            //{

            //    var auth = new UTF8Encoding().GetBytes(user_login + ":" + user_password);
            //    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(auth));

            //    var content = new FormUrlEncodedContent(values);

            //    try
            //    {
            //        response = await httpClient.PostAsync(urlString, content);

            //    }
            //    catch (Exception e)
            //    {
            //        return parts;
            //    }
            //    string respString = await response.Content.ReadAsStringAsync();

            //    JObject jObject = JObject.Parse(respString);
            //    jsonResult = jObject.GetValue("RESP").ToString();

            //}

            string respString = "{\"STATUS\":200,\"MESSAGES\":[],\"RESP\":[{\"PIN\":\"80.09.04\",\"BRAND\":\"ONYARBI\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a !CASSETTE 111x146x24 06.87--\\\\Trailor\",\"ARTID\":\"244235\",\"PARNR\":\"0\",\"KEYZAK\":\"MOV0000170\",\"RVALUE\":\"5\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"100.0\",\"PRICE\":\"461.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201031073000\",\"WRNTDT\":\"\",\"ANALOG\":\"X\"},{\"PIN\":\"80.09.04\",\"BRAND\":\"ONYARBI\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a !CASSETTE 111x146x24 06.87--\\\\Trailor\",\"ARTID\":\"244235\",\"PARNR\":\"0\",\"KEYZAK\":\"MOV0003677\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"98.0\",\"PRICE\":\"461.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201101074500\",\"WRNTDT\":\"\",\"ANALOG\":\"X\"},{\"PIN\":\"80.09.04\",\"BRAND\":\"ONYARBI\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a !CASSETTE 111x146x24 06.87--\\\\Trailor\",\"ARTID\":\"244235\",\"PARNR\":\"0\",\"KEYZAK\":\"MOV0000172\",\"RVALUE\":\"2\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"99.0\",\"PRICE\":\"461.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201102121500\",\"WRNTDT\":\"\",\"ANALOG\":\"X\"},{\"PIN\":\"80.09.04\",\"BRAND\":\"ONYARBI\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a 111\\u0445146\\u044524 \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b (Kassette) TRAILOR L200, N400\",\"ARTID\":\"244235\",\"PARNR\":\"306262\",\"KEYZAK\":\"0000037638\",\"RVALUE\":\"11\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"95.0\",\"PRICE\":\"542.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"A8203\",\"BRAND\":\"UC\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a !111x146x17 06.87--\\\\Trailor\",\"ARTID\":\"244237\",\"PARNR\":\"593885\",\"KEYZAK\":\"0000122226\",\"RVALUE\":\">8\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"95.0\",\"PRICE\":\"629.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"A8203\",\"BRAND\":\"UC\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a !111x146x17 06.87--\\\\Trailor\",\"ARTID\":\"244237\",\"PARNR\":\"374012\",\"KEYZAK\":\"0000050414\",\"RVALUE\":\"8\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"78.0\",\"PRICE\":\"525.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"A8203\",\"BRAND\":\"UC\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a !111x146x17 06.87--\\\\Trailor\",\"ARTID\":\"244237\",\"PARNR\":\"374011\",\"KEYZAK\":\"0000050391\",\"RVALUE\":\"8\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"81.0\",\"PRICE\":\"520.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201105074500\",\"WRNTDT\":\"20201108074500\",\"ANALOG\":\"X\"},{\"PIN\":\"A8203\",\"BRAND\":\"UC\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a !111x146x17 06.87--\\\\Trailor\",\"ARTID\":\"244237\",\"PARNR\":\"177011\",\"KEYZAK\":\"0000018693\",\"RVALUE\":\"12\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"68.0\",\"PRICE\":\"677.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201105074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"A8203\",\"BRAND\":\"UC\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b 110x146x24 110x146x24\",\"ARTID\":\"244237\",\"PARNR\":\"527074\",\"KEYZAK\":\"0000100415\",\"RVALUE\":\"4\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"95.0\",\"PRICE\":\"705.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201106074500\",\"WRNTDT\":\"20201109074500\",\"ANALOG\":\"X\"},{\"PIN\":\"93827\",\"BRAND\":\"DPH\",\"NAME\":\"\\u0440\\/\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b! (\\u0417\\u0410\\u041c\\u0415\\u041d\\u0410 \\u041d\\u0410 DPH1265911) \\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a + \\u043e\\u0431\\u043e\\u0439\\u043c\\u0430 111x113.5x19.5 \\\\Trailor\",\"ARTID\":\"254725\",\"PARNR\":\"368149\",\"KEYZAK\":\"0000049446\",\"RVALUE\":\"1\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"84.0\",\"PRICE\":\"408.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"93827\",\"BRAND\":\"DPH\",\"NAME\":\"\\u0440\\/\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b! (\\u0417\\u0410\\u041c\\u0415\\u041d\\u0410 \\u041d\\u0410 DPH1265911) \\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a + \\u043e\\u0431\\u043e\\u0439\\u043c\\u0430 111x113.5x19.5 \\\\Trailor\",\"ARTID\":\"254725\",\"PARNR\":\"69760\",\"KEYZAK\":\"0000009457\",\"RVALUE\":\"1\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"87.0\",\"PRICE\":\"414.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201106074500\",\"ANALOG\":\"X\"},{\"PIN\":\"196.023-00A\",\"BRAND\":\"PE\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f. \\u043e\\u0441\\u0438 111x146x17 trailor\",\"ARTID\":\"254727\",\"PARNR\":\"577685\",\"KEYZAK\":\"0000116405\",\"RVALUE\":\"7\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"95.0\",\"PRICE\":\"2115.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201108074500\",\"WRNTDT\":\"20201111074500\",\"ANALOG\":\"X\"},{\"PIN\":\"196.023-00A\",\"BRAND\":\"PE\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f. \\u043e\\u0441\\u0438 111x146x17 trailor\",\"ARTID\":\"254727\",\"PARNR\":\"413964\",\"KEYZAK\":\"0000069144\",\"RVALUE\":\"9\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"73.0\",\"PRICE\":\"2213.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201112074500\",\"WRNTDT\":\"20201115074500\",\"ANALOG\":\"X\"},{\"PIN\":\"GR104\",\"BRAND\":\"MANSONS\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a Trailor 110 146 27\",\"ARTID\":\"406811\",\"PARNR\":\"264782\",\"KEYZAK\":\"0000031431\",\"RVALUE\":\"8\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"86.0\",\"PRICE\":\"408.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"GR104\",\"BRAND\":\"MANSONS\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a trailor 110x146x27\",\"ARTID\":\"406811\",\"PARNR\":\"374012\",\"KEYZAK\":\"0000050414\",\"RVALUE\":\"8\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"78.0\",\"PRICE\":\"376.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"GR104\",\"BRAND\":\"MANSONS\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a trailor 110x146x27\",\"ARTID\":\"406811\",\"PARNR\":\"374011\",\"KEYZAK\":\"0000050391\",\"RVALUE\":\"8\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"81.0\",\"PRICE\":\"373.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201105074500\",\"WRNTDT\":\"20201108074500\",\"ANALOG\":\"X\"},{\"PIN\":\"GR104\",\"BRAND\":\"MANSONS\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a 111x146x17 TR \\u043a\\u0430\\u0441\\u0441\\u0435\\u0442\\u043d\\u044b\\u0439 06\\/87--- \\u0436\\u0435\\u043b\\u0435\\u0437\\u043d \\u0433\\u043e\\u043b\\u0443\\u0431\\u043e\\u0439 MANSONS\",\"ARTID\":\"406811\",\"PARNR\":\"186662\",\"KEYZAK\":\"0000063878\",\"RVALUE\":\"14\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"94.0\",\"PRICE\":\"389.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201105094500\",\"WRNTDT\":\"20201107094500\",\"ANALOG\":\"X\"},{\"PIN\":\"6502085P\",\"BRAND\":\"TRAILOR\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b Trailor (110\\u0445146\\u044524\\u043c\\u043c) \\u043a\\u0430\\u0441\\u0441\\u0435\\u0442\\u043d\\u044b\\u0439, \\u043f\\u043e\\u0434\\u0448\\u0438\\u043f\\u043d\\u0438\\u043a\\u0438 (VKHB2205\\/VKHB2226), \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u0430 (A8207)\",\"ARTID\":\"1287487\",\"PARNR\":\"231959\",\"KEYZAK\":\"0000026142\",\"RVALUE\":\"1\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"95.0\",\"PRICE\":\"646.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201103073000\",\"WRNTDT\":\"20201105073000\",\"ANALOG\":\"X\"},{\"PIN\":\"1359639\",\"BRAND\":\"DAF\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a 111x146x17 06.87-- Trailor\",\"ARTID\":\"4277344\",\"PARNR\":\"531989\",\"KEYZAK\":\"0000102038\",\"RVALUE\":\"10\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"50.0\",\"PRICE\":\"1123.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201206074500\",\"WRNTDT\":\"20201209074500\",\"ANALOG\":\"X\"},{\"PIN\":\"1359639\",\"BRAND\":\"DAF\",\"NAME\":\"Seal ring Front axle\",\"ARTID\":\"4277344\",\"PARNR\":\"438061\",\"KEYZAK\":\"0000075845\",\"RVALUE\":\"12\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"74.0\",\"PRICE\":\"1187.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201210074500\",\"WRNTDT\":\"20201213074500\",\"ANALOG\":\"X\"},{\"PIN\":\"A8206\",\"BRAND\":\"UC\",\"NAME\":\"\\u0421\\u0410\\u041b\\u042c\\u041d\\u0418\\u041a \\u0421\\u0422\\u0423\\u041f\\u0418\\u0426\\u042b 110X146X24 110X146X17\",\"ARTID\":\"4277345\",\"PARNR\":\"177011\",\"KEYZAK\":\"0000018693\",\"RVALUE\":\"12\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"68.0\",\"PRICE\":\"870.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201105074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"A8206\",\"BRAND\":\"UC\",\"NAME\":\"\\u0421\\u0410\\u041b\\u042c\\u041d\\u0418\\u041a \\u0421\\u0422\\u0423\\u041f\\u0418\\u0426\\u042b 110x146x17 (6502085P) TRAILOR\",\"ARTID\":\"4277345\",\"PARNR\":\"374011\",\"KEYZAK\":\"0000050391\",\"RVALUE\":\"8\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"81.0\",\"PRICE\":\"638.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201105074500\",\"WRNTDT\":\"20201108074500\",\"ANALOG\":\"X\"},{\"PIN\":\"A8206\",\"BRAND\":\"UC\",\"NAME\":\"\\u0421\\u0410\\u041b\\u042c\\u041d\\u0418\\u041a \\u0421\\u0422\\u0423\\u041f\\u0418\\u0426\\u042b 110x146x17 (6502085P) TRAILOR\",\"ARTID\":\"4277345\",\"PARNR\":\"374012\",\"KEYZAK\":\"0000050414\",\"RVALUE\":\"8\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"78.0\",\"PRICE\":\"644.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"A8206\",\"BRAND\":\"UC\",\"NAME\":\"\\u0421\\u0410\\u041b\\u042c\\u041d\\u0418\\u041a \\u0421\\u0422\\u0423\\u041f\\u0418\\u0426\\u042b 110x146x17 (6502085P) TRAILOR\",\"ARTID\":\"4277345\",\"PARNR\":\"593885\",\"KEYZAK\":\"0000122226\",\"RVALUE\":\">8\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"95.0\",\"PRICE\":\"807.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"1359606\",\"BRAND\":\"DAF\",\"NAME\":\"Seal ring Front axle\",\"ARTID\":\"4277346\",\"PARNR\":\"531989\",\"KEYZAK\":\"0000102038\",\"RVALUE\":\"10\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"50.0\",\"PRICE\":\"3005.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201206074500\",\"WRNTDT\":\"20201209074500\",\"ANALOG\":\"X\"},{\"PIN\":\"1359606\",\"BRAND\":\"DAF\",\"NAME\":\"Seal ring Front axle\",\"ARTID\":\"4277346\",\"PARNR\":\"438061\",\"KEYZAK\":\"0000075845\",\"RVALUE\":\"12\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"74.0\",\"PRICE\":\"3223.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201210074500\",\"WRNTDT\":\"20201213074500\",\"ANALOG\":\"X\"},{\"PIN\":\"082.026\\/1\",\"BRAND\":\"SAMPA\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a TRA 111,13\\u0445146,8\\u044525,81(17)\",\"ARTID\":\"5599984\",\"PARNR\":\"535789\",\"KEYZAK\":\"0000103421\",\"RVALUE\":\"1\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"91.0\",\"PRICE\":\"731.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201105074500\",\"WRNTDT\":\"20201108074500\",\"ANALOG\":\"X\"},{\"PIN\":\"082.026\",\"BRAND\":\"SAMPA\",\"NAME\":\"\\u0440\\/\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b! (\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a 112x142\\/146x11.5\\/24+\\u043e\\u0431\\u043e\\u0439\\u043c\\u0430 111x113.5x19.5) \\\\Trailor\",\"ARTID\":\"5600170\",\"PARNR\":\"525429\",\"KEYZAK\":\"0000100065\",\"RVALUE\":\"18\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"95.0\",\"PRICE\":\"514.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201102074500\",\"WRNTDT\":\"20201105074500\",\"ANALOG\":\"X\"},{\"PIN\":\"082.026\",\"BRAND\":\"SAMPA\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b 110x146x27 Trailor CASSETE\",\"ARTID\":\"5600170\",\"PARNR\":\"236153\",\"KEYZAK\":\"0000026887\",\"RVALUE\":\"1\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"92.0\",\"PRICE\":\"481.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201105074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"83-00452-SX\",\"BRAND\":\"STELLOX\",\"NAME\":\"\\u0440\\/\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b ![6502085P](\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a 112x142\\/146x11.5\\/24. \\u043e\\u0431\\u043e\\u0439\\u043c\\u0430 111x113.5x19.5) \\\\TRAILOR\",\"ARTID\":\"5717726\",\"PARNR\":\"0\",\"KEYZAK\":\"MOV0000170\",\"RVALUE\":\"9\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"100.0\",\"PRICE\":\"434.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201031073000\",\"WRNTDT\":\"\",\"ANALOG\":\"X\"},{\"PIN\":\"83-00452-SX\",\"BRAND\":\"STELLOX\",\"NAME\":\"\\u0440\\/\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b ![6502085P](\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a 112x142\\/146x11.5\\/24. \\u043e\\u0431\\u043e\\u0439\\u043c\\u0430 111x113.5x19.5) \\\\TRAILOR\",\"ARTID\":\"5717726\",\"PARNR\":\"0\",\"KEYZAK\":\"MOV0003677\",\"RVALUE\":\">20\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"98.0\",\"PRICE\":\"434.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201101074500\",\"WRNTDT\":\"\",\"ANALOG\":\"X\"},{\"PIN\":\"83-00452-SX\",\"BRAND\":\"STELLOX\",\"NAME\":\"\\u0440\\/\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b ![6502085P](\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a 112x142\\/146x11.5\\/24. \\u043e\\u0431\\u043e\\u0439\\u043c\\u0430 111x113.5x19.5) \\\\TRAILOR\",\"ARTID\":\"5717726\",\"PARNR\":\"0\",\"KEYZAK\":\"MOV0005269\",\"RVALUE\":\"1\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"99.0\",\"PRICE\":\"434.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201102173000\",\"WRNTDT\":\"\",\"ANALOG\":\"X\"},{\"PIN\":\"1265911\",\"BRAND\":\"DPH\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b\",\"ARTID\":\"7636739\",\"PARNR\":\"549256\",\"KEYZAK\":\"0000107468\",\"RVALUE\":\"27\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"90.0\",\"PRICE\":\"707.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201109074500\",\"WRNTDT\":\"20201111074500\",\"ANALOG\":\"X\"},{\"PIN\":\"1265911\",\"BRAND\":\"DPH\",\"NAME\":\"\\u0440\\/\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b ! (\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a 112x142\\/146x11.5\\/24. \\u043e\\u0431\\u043e\\u0439\\u043c\\u0430 111x113.5x19.5) \\\\TRAILOR\",\"ARTID\":\"7636739\",\"PARNR\":\"374011\",\"KEYZAK\":\"0000050391\",\"RVALUE\":\"6\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"81.0\",\"PRICE\":\"664.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201105074500\",\"WRNTDT\":\"20201108074500\",\"ANALOG\":\"X\"},{\"PIN\":\"1265911\",\"BRAND\":\"DPH\",\"NAME\":\"\\u0440\\/\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b ! (\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a 112x142\\/146x11.5\\/24. \\u043e\\u0431\\u043e\\u0439\\u043c\\u0430 111x113.5x19.5) \\\\TRAILOR\",\"ARTID\":\"7636739\",\"PARNR\":\"374012\",\"KEYZAK\":\"0000050414\",\"RVALUE\":\"6\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"0\",\"VENSL\":\"78.0\",\"PRICE\":\"670.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"1265911\",\"BRAND\":\"DPH\",\"NAME\":\"\\u0440\\/\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b ! (\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a 112x142\\/146x11.5\\/24. \\u043e\\u0431\\u043e\\u0439\\u043c\\u0430 111x113.5x19.5) \\\\TRAILOR\",\"ARTID\":\"7636739\",\"PARNR\":\"264782\",\"KEYZAK\":\"0000031431\",\"RVALUE\":\"6\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"86.0\",\"PRICE\":\"694.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"GR176\",\"BRAND\":\"MANSONS\",\"NAME\":\"\\u0421\\u0410\\u041b\\u042c\\u041d\\u0418\\u041a \\u0421\\u0422\\u0423\\u041f\\u0418\\u0426\\u042b TR 6502085 MANSONS\",\"ARTID\":\"9078589\",\"PARNR\":\"601973\",\"KEYZAK\":\"0000125351\",\"RVALUE\":\"6\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"88.0\",\"PRICE\":\"892.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201103073000\",\"WRNTDT\":\"20201104073000\",\"ANALOG\":\"X\"},{\"PIN\":\"GR176\",\"BRAND\":\"MANSONS\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b 111\\u0445145\\u044525 Trailor (\\u0441 \\u043f\\u0440\\u043e\\u043a\\u043b\\u0430\\u0434\\u043a\\u043e\\u0439)\",\"ARTID\":\"9078589\",\"PARNR\":\"172212\",\"KEYZAK\":\"0000051526\",\"RVALUE\":\"1\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"90.0\",\"PRICE\":\"535.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201111074500\",\"WRNTDT\":\"20201113074500\",\"ANALOG\":\"X\"},{\"PIN\":\"55801\",\"BRAND\":\"AUGER\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b! 110x146x16.5\\\\ TRAILOR\",\"ARTID\":\"9155775\",\"PARNR\":\"0\",\"KEYZAK\":\"MOV0000176\",\"RVALUE\":\"1\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"98.0\",\"PRICE\":\"522.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201101074500\",\"WRNTDT\":\"\",\"ANALOG\":\"X\"},{\"PIN\":\"55801\",\"BRAND\":\"AUGER\",\"NAME\":\"\\u0423\\u043f\\u043bo\\u0442\\u043d\\u0438\\u0442e\\u043b\\u044c\\u043doe \\u043ao\\u043b\\u044c\\u0446o, \\u0421\\u0442\\u0443\\u043f\\u0438\\u0446\\u0430 \\u043a\\u043e\\u043b\\u0435\\u0441\\u0430\",\"ARTID\":\"9155775\",\"PARNR\":\"432546\",\"KEYZAK\":\"0000073331\",\"RVALUE\":\"3\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"95.0\",\"PRICE\":\"429.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201102074500\",\"WRNTDT\":\"20201104074500\",\"ANALOG\":\"X\"},{\"PIN\":\"55801\",\"BRAND\":\"AUGER\",\"NAME\":\"\\u0441\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b! 110x146x16.5\\\\ TRAILOR\",\"ARTID\":\"9155775\",\"PARNR\":\"0\",\"KEYZAK\":\"MOV0005269\",\"RVALUE\":\"1\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"99.0\",\"PRICE\":\"517.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201102173000\",\"WRNTDT\":\"\",\"ANALOG\":\"X\"},{\"PIN\":\"55801\",\"BRAND\":\"AUGER\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f TRAILOR 111x146x24 V6502085P\",\"ARTID\":\"9155775\",\"PARNR\":\"484965\",\"KEYZAK\":\"0000086831\",\"RVALUE\":\"8\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"79.0\",\"PRICE\":\"488.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201113074500\",\"WRNTDT\":\"20201115074500\",\"ANALOG\":\"X\"},{\"PIN\":\"55802\",\"BRAND\":\"AUGER\",\"NAME\":\"\\u0423\\u043f\\u043bo\\u0442\\u043d\\u0438\\u0442e\\u043b\\u044c\\u043doe \\u043ao\\u043b\\u044c\\u0446o, \\u0421\\u0442\\u0443\\u043f\\u0438\\u0446\\u0430 \\u043a\\u043e\\u043b\\u0435\\u0441\\u0430\",\"ARTID\":\"9155776\",\"PARNR\":\"432546\",\"KEYZAK\":\"0000073331\",\"RVALUE\":\"3\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"95.0\",\"PRICE\":\"551.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201102074500\",\"WRNTDT\":\"20201104074500\",\"ANALOG\":\"X\"},{\"PIN\":\"GR187\",\"BRAND\":\"MANSONS\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b 111x146x26 Trailor\",\"ARTID\":\"12311803\",\"PARNR\":\"228183\",\"KEYZAK\":\"0000025501\",\"RVALUE\":\"1\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"95.0\",\"PRICE\":\"456.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104073000\",\"WRNTDT\":\"20201106073000\",\"ANALOG\":\"X\"},{\"PIN\":\"TR2512005\",\"BRAND\":\"ALON\",\"NAME\":\"OIL SEAL TRAILOR 146x110x24 (6502085P)\",\"ARTID\":\"12800809\",\"PARNR\":\"320171\",\"KEYZAK\":\"0000041218\",\"RVALUE\":\"8\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"88.0\",\"PRICE\":\"494.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"GR176A\",\"BRAND\":\"MANSONS\",\"NAME\":\"\\u0421\\u0410\\u041b\\u042c\\u041d\\u0418\\u041a \\u0421\\u0422\\u0423\\u041f\\u0418\\u0426\\u042b TR 6502085 MANSONS\",\"ARTID\":\"16627694\",\"PARNR\":\"601973\",\"KEYZAK\":\"0000125351\",\"RVALUE\":\"4\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"88.0\",\"PRICE\":\"804.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201103073000\",\"WRNTDT\":\"20201104073000\",\"ANALOG\":\"X\"},{\"PIN\":\"372-7050\",\"BRAND\":\"STEMCO\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b \\u043a\\u043e\\u043b\\u0435\\u0441\\u0430 \\u0430\\u0432\\u0442\\u043e\\u043c\\u043e\\u0431\\u0438\\u043b\\u044f\",\"ARTID\":\"28166024\",\"PARNR\":\"555878\",\"KEYZAK\":\"0000109162\",\"RVALUE\":\"2\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"78.0\",\"PRICE\":\"636.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201104074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"},{\"PIN\":\"372-7050\",\"BRAND\":\"STEMCO\",\"NAME\":\"\\u0421\\u0430\\u043b\\u044c\\u043d\\u0438\\u043a \\u0441\\u0442\\u0443\\u043f\\u0438\\u0446\\u044b \\u043a\\u043e\\u043b\\u0435\\u0441\\u0430 \\u0430\\u0432\\u0442\\u043e\\u043c\\u043e\\u0431\\u0438\\u043b\\u044f YORK 110x146x22\",\"ARTID\":\"28166024\",\"PARNR\":\"396944\",\"KEYZAK\":\"0000059510\",\"RVALUE\":\"2\",\"RDPRF\":\"1\",\"MINBM\":\"1.000\",\"RETDAYS\":\"14\",\"VENSL\":\"90.0\",\"PRICE\":\"556.00\",\"WAERS\":\"RUB\",\"DLVDT\":\"20201105074500\",\"WRNTDT\":\"20201107074500\",\"ANALOG\":\"X\"}]}";

            JObject jObject = JObject.Parse(respString);
            jsonResult = jObject.GetValue("RESP").ToString();

            RESP[] items;
            try
            {
                items = JsonConvert.DeserializeObject<RESP[]>(jsonResult);
            }
            catch
            {
                return parts;
            }

            
            int count = 0;
            foreach (RESP p in items)
            {
                double price;
                bool priceSuccess = Double.TryParse(p.PRICE.Replace(".", ","), out price);
                double sPrice = Math.Round(price + price * 0.2);
                string rValue = p.RVALUE;
                int rValueToInt;
                if (p.RVALUE.Contains(">")) rValue = "10";
                bool success = Int32.TryParse(rValue, out rValueToInt);

                CultureInfo provider = CultureInfo.InvariantCulture;
                string format = "yyyyMMddHHmmss";
                DateTime date;
                if (p.WRNTDT == "")
                {
                    date = DateTime.ParseExact(p.DLVDT, format, provider).AddDays(1);
                }
                else
                {
                    date = DateTime.ParseExact(p.WRNTDT, format, provider).AddDays(1);
                }

                if (success && priceSuccess)
                {

                    parts.Add(new SearchPart()
                    {
                        PartId = count++,
                        VendorId = 1,
                        Brand = p.BRAND,
                        PartNumber = p.PIN,
                        QuantityInStock = rValueToInt,
                        BuyingPrice = Convert.ToDecimal(price),
                        SellingPrice = Convert.ToDecimal(sPrice),
                        PartName = p.NAME,
                        DeliveryDate = date

                    }); ; ;
                }

            }
            return parts;
        }

    }


    public class RESP
    {
        public string PIN { get; set; }
        public string BRAND { get; set; }
        public string NAME { get; set; }
        public string ARTID { get; set; }
        public string PARNR { get; set; }
        public string KEYZAK { get; set; }
        public string RVALUE { get; set; }
        public string RDPRF { get; set; }
        public string MINBM { get; set; }
        public string RETDAYS { get; set; }
        public string VENSL { get; set; }
        public string PRICE { get; set; }
        public string WAERS { get; set; }
        public string DLVDT { get; set; }
        public string WRNTDT { get; set; }
        public string ANALOG { get; set; }
    }



}
