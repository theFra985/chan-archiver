﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AniWrap.Helpers;
using System.Web;

namespace AniWrap.DataTypes
{
    public class GenericPost
    {
        public GenericPost()
        {
            this.Capcode = CapcodeEnum.None;
        }
        
        public int ID { get; set; }

        public DateTime Time;

        public string Comment { get; set; }

        private string _comment_text = "";

        public string CommentText
        {
            get
            {
                if (_comment_text == "")
                {
                    _comment_text = Common.DecodeHTML(this.Comment);
                    return _comment_text;
                }
                else
                {
                    return _comment_text;
                }
            }
        }

        public GenericPost OwnerThread { get; set; }

        public string Subject { get; set; }
        public string Trip { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PosterID { get; set; }
        public string Board { get; set; }

        public PostFile File;

        public CapcodeEnum Capcode { get; set; }

        public string country_flag { get; set; }
        public string country_name { get; set; }

        public enum CapcodeEnum { Admin, Mod, Developer, None }

        public bool IsOpPost { get { return this.GetType() == typeof(Thread); } }

      //  public CommentToken[] CommentTokens { get { return ThreadHelper.TokenizeComment(this.Comment); } }

    }
}
