// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Per-file result for <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.ListFileMembersBatchAsync"
    /// />.</para>
    /// </summary>
    public class ListFileMembersBatchResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListFileMembersBatchResult> Encoder = new ListFileMembersBatchResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListFileMembersBatchResult> Decoder = new ListFileMembersBatchResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFileMembersBatchResult" />
        /// class.</para>
        /// </summary>
        /// <param name="file">This is the input file identifier, whether an ID or a
        /// path.</param>
        /// <param name="result">The result for this particular file</param>
        public ListFileMembersBatchResult(string file,
                                          ListFileMembersIndividualResult result)
        {
            if (file == null)
            {
                throw new sys.ArgumentNullException("file");
            }
            if (file.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("file", "Length should be at least 1");
            }
            if (!re.Regex.IsMatch(file, @"\A(?:((/|id:).*|nspath:[0-9]+:.*)|ns:[0-9]+(/.*)?)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("file", @"Value should match pattern '\A(?:((/|id:).*|nspath:[0-9]+:.*)|ns:[0-9]+(/.*)?)\z'");
            }

            if (result == null)
            {
                throw new sys.ArgumentNullException("result");
            }

            this.File = file;
            this.Result = result;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFileMembersBatchResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListFileMembersBatchResult()
        {
        }

        /// <summary>
        /// <para>This is the input file identifier, whether an ID or a path.</para>
        /// </summary>
        public string File { get; protected set; }

        /// <summary>
        /// <para>The result for this particular file</para>
        /// </summary>
        public ListFileMembersIndividualResult Result { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListFileMembersBatchResult" />.</para>
        /// </summary>
        private class ListFileMembersBatchResultEncoder : enc.StructEncoder<ListFileMembersBatchResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListFileMembersBatchResult value, enc.IJsonWriter writer)
            {
                WriteProperty("file", value.File, writer, enc.StringEncoder.Instance);
                WriteProperty("result", value.Result, writer, Dropbox.Api.Sharing.ListFileMembersIndividualResult.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListFileMembersBatchResult" />.</para>
        /// </summary>
        private class ListFileMembersBatchResultDecoder : enc.StructDecoder<ListFileMembersBatchResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListFileMembersBatchResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListFileMembersBatchResult Create()
            {
                return new ListFileMembersBatchResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListFileMembersBatchResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file":
                        value.File = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "result":
                        value.Result = Dropbox.Api.Sharing.ListFileMembersIndividualResult.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
