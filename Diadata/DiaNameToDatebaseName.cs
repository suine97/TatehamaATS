﻿//括弧やセミコロン、カンマなどの数等に注意する。
//また、辞書以外を弄らないこと。
namespace TatehamaATS.Diadata
{
    internal class DiaNameToDatebaseName
    {
        private Dictionary<string, string> 列番変換辞書;
        public DiaNameToDatebaseName()
        {
            列番変換辞書 = new Dictionary<string, string>{   
                //--編集可能ここから     
                //通常使用部分       
                {"551", "回451"},
                {"581C", "581"},
                {"592", "592C"}, 

                //運転会用部分
                //通常列番
                {"回1013A", "回1105A"},
                {"1112A", "1204A"},
                {"1017A", "1107A"},
                {"回1216A", "回1306A"},
                {"回1217A", "回1105A"},
                {"1316A", "1204A"},
                {"1075", "1261"},
                {"1174", "1260"},
                {"1275", "1261"},
                {"1274", "1166"},
                {"1060", "1166"},
                {"1161", "1267"},
                {"1183C", "1283C"},
                {"1182C", "1282C"},
                {"1168C", "1284C"},
                {"1169C", "1285C"},
                {"1268C", "1284C"},
                {"1269C", "1285C"},
                {"1011A", "1209A"},
                {"1110A", "1204A"},
                {"1103A", "1209A"},
                {"回1104A", "回1306A"},
                {"1164", "1260"},
                {"1165", "1261"},
                {"1264", "1260"},
                {"1167", "1261"},
                {"1185C", "1285C"},
                {"1184C", "1284C"},

                //試運転
                {"回7190", "回862"},
                {"回7191", "回607A"},
                {"回7290", "回862"},
                {"回7291", "回607A"},

                //新だんじり
                {"回7281", "回607A"},
                {"回1195", "回607A"},
                {"回1181X", "回607A"},
                {"回1281X", "回607A"},
                {"回7181", "回771"},
                {"回7283", "回771"},
                {"回1181", "回771"},
                {"回1281", "回771"},
                {"6981K", "3643K"},
                {"7185K", "3643K"},
                {"7083K", "3643K"},
                {"7280K", "796K"},
                {"1194K", "796K"},
                {"7281B", "回607A"},
                {"1195B", "回607A"},
                {"1181B", "回607A"},
                {"1281B", "回607A"},
                {"7180C", "2084C"},
                {"7282C", "2084C"},
                {"1180C", "2084C"},
                {"1280C", "2084C"},

                //92年通常ダイヤ
                {"1108A", "1204A"},
                {"1015A", "1209A"},
                {"1214A", "1204A"},
                {"1103A", "1209A"},
                {"1302A", "1204A"},
                {"1011A", "1209A"},
                {"1110A", "1204A"},
                {"1105A", "1209A"},
                {"1204A", "1204A"},
                {"1213A", "1209A"},
                {"1158", "1260"},
                {"1159", "1261"},
                {"1258", "1260"},
                {"1259", "1261"},
                {"1153", "1261"},
                {"1152", "1260"},
                {"1253", "1261"},
                {"1252", "1260"},
                {"1182B", "678B"},
                {"1181B", "3643K"},
                {"1280B", "678B"},
                {"1279B", "3643K"},
                {"1073B", "3643K"},
                {"1172B", "678B"},
                {"1187B", "3643K"},
                {"1286B", "678B"},
                {"1144", "1260"},
                {"1145", "1261"},
                {"1244", "1260"},
                {"1245", "1261"},
                {"1157", "1261"},
                {"1156", "1260"},
                {"1257", "1261"},
                {"1256", "1260"},
                {"回7101", "回607A"},
                {"回7200", "回862"},
                
                //92年催事ダイヤ
                {"1112A", "1204A"},
                {"1017A", "1209A"},
                {"1216A", "1204A"},
                {"1107A", "1209A"},
                {"1011A", "1209A"},
                {"1110A", "1204A"},
                {"1103A", "1209A"},
                {"1202A", "1204A"},
                {"1209A", "1209A"},
                {"1306A", "1204A"},
                {"1134B", "678B"},
                {"1130B", "678B"},
                {"1246B", "678B"},
                {"1244B", "678B"},
                {"1240B", "678B"},
                {"1136B", "678B"},
                {"1132B", "678B"},
                {"1242B", "678B"},
                {"1248B", "678B"},
                {"1138B", "678B"},
                {"1041B", "3643K"},
                {"1037B", "3643K"},
                {"1035B", "3643K"},
                {"1231B", "3643K"},
                {"1147B", "3643K"},
                {"1143B", "3643K"},
                {"1039B", "3643K"},
                {"1149B", "3643K"},
                {"1145B", "3643K"},
                {"1160", "1166"},
                {"1064", "1166"},
                {"1264", "1166"},
                {"1260", "1166"},
                {"1164", "1166"},
                {"1274", "1260"},
                {"1166", "1260"},
                {"1174", "1260"},
                {"1266", "1260"},
                {"1275", "1261"},
                {"1267", "1261"},
                {"1175", "1261"},
                {"1167", "1261"},
                {"1161", "1267"},
                {"1165", "1267"},
                {"1061", "1267"},
                {"1261", "1267"},
                {"1265", "1267"},
                {"回7001", "回607A"},
                {"回7200", "回862"},

                //着線別入力用列番
                {"9410", "1166"}, //普通　津崎１番線着
                {"9420", "1260"}, //普通　津崎２番線着
                {"9034", "1261"}, //普通　津崎３番線着
                {"9044", "1267"}, //普通　津崎４番線着
                {"9200B", "3643K"}, //急行　館浜２番線発
                {"9002B", "678B"},　//急行　館浜２番線着
                {"9110A", "1204A"}, //C特1　館浜１番線発     
                {"9201A", "1209A"}, //C特2　館浜１番線着

                //--編集可能ここまで
            };
        }

        public string ChengeDiaName(string DiaName)
        {
            if (列番変換辞書.ContainsKey(DiaName))
            {
                return 列番変換辞書[DiaName];
            }
            return DiaName;
        }
    }
}