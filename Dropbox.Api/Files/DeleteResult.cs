// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The delete result object</para>
    /// </summary>
    public class DeleteResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DeleteResult> Encoder = new DeleteResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DeleteResult> Decoder = new DeleteResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeleteResult" /> class.</para>
        /// </summary>
        /// <param name="metadata">The metadata</param>
        public DeleteResult(Metadata metadata)
        {
            if (metadata == null)
            {
                throw new sys.ArgumentNullException("metadata");
            }

            this.Metadata = metadata;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="DeleteResult" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public DeleteResult()
        {
        }

        /// <summary>
        /// <para>Gets the metadata of the delete result</para>
        /// </summary>
        public Metadata Metadata { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DeleteResult" />.</para>
        /// </summary>
        private class DeleteResultEncoder : enc.StructEncoder<DeleteResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DeleteResult value, enc.IJsonWriter writer)
            {
                WriteProperty("metadata", value.Metadata, writer, Dropbox.Api.Files.Metadata.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DeleteResult" />.</para>
        /// </summary>
        private class DeleteResultDecoder : enc.StructDecoder<DeleteResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="DeleteResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DeleteResult Create()
            {
                return new DeleteResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DeleteResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "metadata":
                        value.Metadata = Dropbox.Api.Files.Metadata.Decoder.Decode(reader);
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
