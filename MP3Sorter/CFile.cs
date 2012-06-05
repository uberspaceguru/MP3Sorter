using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace MP3Sorter
{
    class CFile
    {
        private string m_MD5checksum;
        private string m_FilePath;
        private string m_FileName;
        private string m_FileType;
        private ArrayList m_Related;

        #region read only properties
        public string checkSum
        {
            get
            {
                return m_MD5checksum;
            }
        }

        public string filePath
        {
            get
            {
                return m_FileName;
            }
        }

        public string fileName
        {
            get
            {
                return m_FileName;
            }
        }

        public string fileType
        {
            get
            {
                return m_FileType;
            }
        }

        public string fullFileName
        {
            get
            {
                return m_FilePath + m_FileName + m_FileType;
            }
        }
        #endregion

        #region public functions
        public CFile(string filenameWithPath)
        {
            extractFileInfo(filenameWithPath);
            generateMD5(filenameWithPath); 
        }

        //don't know exactly what constitutes a relationship, so there is no validation
        //for now relationships are "duplicates"
        public void addRelatedFile(CFile relatedFile)
        {
            //avoid duplicate entries
            if(!m_Related.Contains(relatedFile))
                m_Related.Add(relatedFile);
            relatedFile.addRelatedFile(this);
        }
        #endregion

        #region Helper Functions
        private void generateMD5(string fName)
        { 
            FileStream file = new FileStream(fName, FileMode.Open);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();
            ASCIIEncoding enc = new ASCIIEncoding();
            m_MD5checksum = enc.GetString(retVal);    
        }

        private void extractFileInfo(string sFullFileName)
        {
            int idxStart = sFullFileName.LastIndexOf("\\");
            idxStart++;
            int idxEnd = sFullFileName.LastIndexOf(".");
            m_FileName = sFullFileName.Substring(idxStart, (idxEnd-idxStart));
            m_FilePath = sFullFileName.Substring(0, idxStart);
            m_FileType = sFullFileName.Substring(idxEnd);            
        }


        #endregion
    }
}
