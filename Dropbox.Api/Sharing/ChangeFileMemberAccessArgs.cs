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
    /// <para>Arguments for <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.ChangeFileMemberAccessAsync"
    /// />.</para>
    /// </summary>
    public class ChangeFileMemberAccessArgs
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ChangeFileMemberAccessArgs> Encoder = new ChangeFileMemberAccessArgsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ChangeFileMemberAccessArgs> Decoder = new ChangeFileMemberAccessArgsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ChangeFileMemberAccessArgs" />
        /// class.</para>
        /// </summary>
        /// <param name="file">File for which we are changing a member's access.</param>
        /// <param name="member">The member whose access we are changing.</param>
        /// <param name="accessLevel">The new access level for the member.</param>
        public ChangeFileMemberAccessArgs(string file,
                                          MemberSelector member,
                                          AccessLevel accessLevel)
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

            if (member == null)
            {
                throw new sys.ArgumentNullException("member");
            }

            if (accessLevel == null)
            {
                throw new sys.ArgumentNullException("accessLevel");
            }

            this.File = file;
            this.Member = member;
            this.AccessLevel = accessLevel;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ChangeFileMemberAccessArgs" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ChangeFileMemberAccessArgs()
        {
        }

        /// <summary>
        /// <para>File for which we are changing a member's access.</para>
        /// </summary>
        public string File { get; protected set; }

        /// <summary>
        /// <para>The member whose access we are changing.</para>
        /// </summary>
        public MemberSelector Member { get; protected set; }

        /// <summary>
        /// <para>The new access level for the member.</para>
        /// </summary>
        public AccessLevel AccessLevel { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ChangeFileMemberAccessArgs" />.</para>
        /// </summary>
        private class ChangeFileMemberAccessArgsEncoder : enc.StructEncoder<ChangeFileMemberAccessArgs>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ChangeFileMemberAccessArgs value, enc.IJsonWriter writer)
            {
                WriteProperty("file", value.File, writer, enc.StringEncoder.Instance);
                WriteProperty("member", value.Member, writer, Dropbox.Api.Sharing.MemberSelector.Encoder);
                WriteProperty("access_level", value.AccessLevel, writer, Dropbox.Api.Sharing.AccessLevel.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ChangeFileMemberAccessArgs" />.</para>
        /// </summary>
        private class ChangeFileMemberAccessArgsDecoder : enc.StructDecoder<ChangeFileMemberAccessArgs>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ChangeFileMemberAccessArgs"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ChangeFileMemberAccessArgs Create()
            {
                return new ChangeFileMemberAccessArgs();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ChangeFileMemberAccessArgs value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file":
                        value.File = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member":
                        value.Member = Dropbox.Api.Sharing.MemberSelector.Decoder.Decode(reader);
                        break;
                    case "access_level":
                        value.AccessLevel = Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
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
