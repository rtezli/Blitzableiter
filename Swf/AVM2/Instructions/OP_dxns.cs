using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Recurity.Swf.AVM2.Instructions
{
    /// <summary>
    /// 
    /// </summary>
	public class OP_dxns : AbstractInstruction
	{
        /// <summary>
        /// 
        /// </summary>
        protected UInt32 _Index;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceStream"></param>
        protected override void Parse( BinaryReader sourceStream )
        {
            _Index = AVM2.Static.VariableLengthInteger.ReadU30( sourceStream );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="abc"></param>
        public override void Verify( ABC.AbcFile abc )
        {
            if ( !abc.VerifyStringIndex( _Index ) )
            {
                throw new AbcVerifierException( "Invalid string index" );
            }

            try
            {
                UriBuilder urib = new UriBuilder( abc.ConstantPool.Strings[ ( int )_Index ] );
            }
            catch ( UriFormatException urie )
            {
                throw new AbcVerifierException( "dxns URI format error: " + abc.ConstantPool.Strings[ ( int )_Index ], urie );
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="destination"></param>
        protected override void WriteArgs( Stream destination )
        {
            AVM2.Static.VariableLengthInteger.WriteU30( destination, _Index );         
        }

        /// <summary>
        /// 
        /// </summary>
        public override uint Length
        {
            get
            {
                return 1 + AVM2.Static.VariableLengthInteger.EncodedLengthU30( _Index );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string name = base.ToString();
            string ret = name + " (index: " + _Index.ToString( "d" ) + ")";
            return ret;
        }
	}
}
