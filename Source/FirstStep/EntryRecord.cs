using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    public class EntryRecord
    {
        /// <summary>
        /// 数値(32bit符号付整数)【値型】
        /// [int以外の整数型]
        /// sbyte:8bit符号付き
        /// short:16bit符号付き
        /// long:64bit符号付き
        /// byte:8bit符号無し
        /// ushort:16bit符号無し
        /// ulong:64bit符号無し
        /// </summary>
        public int MemberID { get; private set; }
        /// <summary>
        /// 日付時間型【値型】
        /// </summary>
        public DateTime EntryDate { get; set; }
        /// <summary>
        /// 文字列型【参照型】
        /// </summary>
        public string WorkingPlace { get; set; }
        /// <summary>
        /// ブール型（真偽値：true/false）【値型】
        /// </summary>
        public bool Anonymous { get; set; }
        /// <summary>
        /// 文字列型【参照型】
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 構造体（色の構造体）【値型】
        /// </summary>
        public Color HelmetColor { get; set; }
        /// <summary>
        /// 少数点を含む数値【値型】
        /// この他小数点を含む数値は浮動小数点式の下記型があるが、誤差が生じるのでdecimalを使用する。
        /// float:単精度浮動小数点
        /// double:倍精度浮動小数点
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// パラメータ無しのコンストラクタ
        /// このコンストラクタを記述しなくても、コンパイラがデフォルトコンストラクタとして自動生成する。
        /// このクラスのインスタンスが生成される時に実行される
        /// </summary>
        public EntryRecord() { }
        /// <summary>
        /// パラメータがあるコンストラクタ
        /// 初期値等をパラメータによって指定する事ができる。
        /// このクラスのインスタンスが生成される時に実行される
        /// </summary>
        /// <param name="memberID"></param>
        /// <param name="entryDate"></param>
        /// <param name="workingPlace"></param>
        /// <param name="anonymous"></param>
        /// <param name="name"></param>
        /// <param name="helmetColor"></param>
        /// <param name="weight"></param>
        public EntryRecord(int memberID, DateTime entryDate, string workingPlace, bool anonymous, string name, Color helmetColor, decimal weight) 
        {
            this.MemberID = memberID;
            this.EntryDate = entryDate;
            this.WorkingPlace = workingPlace;
            this.Anonymous = anonymous;
            this.Name = name;
            this.HelmetColor = helmetColor;
            this.Weight = weight;
        }
        public int ElapsedDays 
        {
            get 
            {
                return (int)(DateTime.Now.Date - this.EntryDate.Date).TotalDays; 
            }
        }
        public string ToCSVRecord(string delimiter = ",")
        {
            return $"{this.MemberID}{delimiter}{this.EntryDate}{delimiter}{this.WorkingPlace}{delimiter}{this.Anonymous}{delimiter}{this.Name}{delimiter}{this.HelmetColor}{delimiter}{this.Weight}";
        }
    }
}
