﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Recurity.Blitzableiter.SWF
{
    /// <summary>
    /// The type Information of a H.263 encoded video.
    /// </summary>
    public class H263TypeInformation :  AbstractSwfElement
    {
        /// <summary>
        /// The type Information of a H.263 encoded video.
        /// </summary>
        /// <param name="InitialVersion">The version of the SWF file using this object.</param>
        public H263TypeInformation(byte InitialVersion) : base(InitialVersion)
        {

        }

        /// <summary>
        /// The length of this tag including the header.
        /// </summary>
        public ulong Length
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Verifies this object and its components for documentation compliance.
        /// </summary>
        /// <returns>True if the object is documentation compliant.</returns>
        public bool Verify()
        {
            return true;
        }

        /// <summary>
        /// Parses this object out of a stream
        /// </summary>
        public void Parse(Stream input)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            BitStream bits = new BitStream(input);
        }

        /// <summary>
        /// Writes this object back to a stream
        /// </summary>
        /// <param name="output">The stream to write to.</param>
        public void Write(Stream output)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }

        /// <summary>
        /// Converts the value of this instance to a System.String.
        /// </summary>
        /// <returns>A string whose value is the same as this instance.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}
