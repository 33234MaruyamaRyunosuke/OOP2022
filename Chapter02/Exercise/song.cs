using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class song {

        //プロパティ
        
        public string Title { get; set; }//歌のタイトル
        
        public string ArtistName { get; set; }//アーティスト名

        public int Length { get; set; } //演奏時間(秒)

        //因数付きコンストラクタ
        public song() {

        }
    }
}
