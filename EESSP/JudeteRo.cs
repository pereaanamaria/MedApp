using System.Windows.Forms;

namespace EESSP
{
    class JudeteRo
    {
        public string getJudet(string cod)
        {
            switch (cod)
            {
                case "01": return "Alba";
                case "02": return "Arad";
                case "03": return "Argeș";
                case "04": return "Bacău";
                case "05": return "Bihor";
                case "06": return "Bistrița-Năsăud";
                case "07": return "Botoșani";
                case "08": return "Brașov";
                case "09": return "Brăila";
                case "10": return "Buzău";
                case "11": return "Caraș-Severin";
                case "12": return "Cluj";
                case "13": return "Constanța";
                case "14": return "Covasna";
                case "15": return "Dâmbovița";
                case "16": return "Dolj";
                case "17": return "Galați";
                case "18": return "Gorj";
                case "19": return "Harghita";
                case "20": return "Hunedoara";
                case "21": return "Ialomița";
                case "22": return "Iași";
                case "23": return "Ilfov";
                case "24": return "Maramureș";
                case "25": return "Mehedinți";
                case "26": return "Mureș";
                case "27": return "Neamț";
                case "28": return "Olt";
                case "29": return "Prahova";
                case "30": return "Satu Mare";
                case "31": return "Sălaj";
                case "32": return "Sibiu";
                case "33": return "Suceava";
                case "34": return "Teleorman";
                case "35": return "Timiș";
                case "36": return "Tulcea";
                case "37": return "Vaslui";
                case "38": return "Vâlcea";
                case "39": return "Vrancea";
                case "40": return "București";
                case "41": return "București - Sector 1";
                case "42": return "București - Sector 2";
                case "43": return "București - Sector 3";
                case "44": return "București - Sector 4";
                case "45": return "București - Sector 5";
                case "46": return "București - Sector 6";
                case "51": return "Călărași";
                case "52": return "Giurgiu";
                default:
                    MessageBox.Show("Invalid CNP!");
                    break;
            }
            return null;
        }
    }
}
