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
    /// <para>Sharing actions that may be taken on files.</para>
    /// </summary>
    public class FileAction
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileAction> Encoder = new FileActionEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileAction> Decoder = new FileActionDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileAction" /> class.</para>
        /// </summary>
        public FileAction()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is EditContents</para>
        /// </summary>
        public bool IsEditContents
        {
            get
            {
                return this is EditContents;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a EditContents, or <c>null</c>.</para>
        /// </summary>
        public EditContents AsEditContents
        {
            get
            {
                return this as EditContents;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InviteViewer</para>
        /// </summary>
        public bool IsInviteViewer
        {
            get
            {
                return this is InviteViewer;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InviteViewer, or <c>null</c>.</para>
        /// </summary>
        public InviteViewer AsInviteViewer
        {
            get
            {
                return this as InviteViewer;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InviteViewerNoComment</para>
        /// </summary>
        public bool IsInviteViewerNoComment
        {
            get
            {
                return this is InviteViewerNoComment;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InviteViewerNoComment, or <c>null</c>.</para>
        /// </summary>
        public InviteViewerNoComment AsInviteViewerNoComment
        {
            get
            {
                return this as InviteViewerNoComment;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Unshare</para>
        /// </summary>
        public bool IsUnshare
        {
            get
            {
                return this is Unshare;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Unshare, or <c>null</c>.</para>
        /// </summary>
        public Unshare AsUnshare
        {
            get
            {
                return this as Unshare;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is RelinquishMembership</para>
        /// </summary>
        public bool IsRelinquishMembership
        {
            get
            {
                return this is RelinquishMembership;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a RelinquishMembership, or <c>null</c>.</para>
        /// </summary>
        public RelinquishMembership AsRelinquishMembership
        {
            get
            {
                return this as RelinquishMembership;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is ShareLink</para>
        /// </summary>
        public bool IsShareLink
        {
            get
            {
                return this is ShareLink;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a ShareLink, or <c>null</c>.</para>
        /// </summary>
        public ShareLink AsShareLink
        {
            get
            {
                return this as ShareLink;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is CreateLink</para>
        /// </summary>
        public bool IsCreateLink
        {
            get
            {
                return this is CreateLink;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a CreateLink, or <c>null</c>.</para>
        /// </summary>
        public CreateLink AsCreateLink
        {
            get
            {
                return this as CreateLink;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileAction" />.</para>
        /// </summary>
        private class FileActionEncoder : enc.StructEncoder<FileAction>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileAction value, enc.IJsonWriter writer)
            {
                if (value is EditContents)
                {
                    WriteProperty(".tag", "edit_contents", writer, enc.StringEncoder.Instance);
                    EditContents.Encoder.EncodeFields((EditContents)value, writer);
                    return;
                }
                if (value is InviteViewer)
                {
                    WriteProperty(".tag", "invite_viewer", writer, enc.StringEncoder.Instance);
                    InviteViewer.Encoder.EncodeFields((InviteViewer)value, writer);
                    return;
                }
                if (value is InviteViewerNoComment)
                {
                    WriteProperty(".tag", "invite_viewer_no_comment", writer, enc.StringEncoder.Instance);
                    InviteViewerNoComment.Encoder.EncodeFields((InviteViewerNoComment)value, writer);
                    return;
                }
                if (value is Unshare)
                {
                    WriteProperty(".tag", "unshare", writer, enc.StringEncoder.Instance);
                    Unshare.Encoder.EncodeFields((Unshare)value, writer);
                    return;
                }
                if (value is RelinquishMembership)
                {
                    WriteProperty(".tag", "relinquish_membership", writer, enc.StringEncoder.Instance);
                    RelinquishMembership.Encoder.EncodeFields((RelinquishMembership)value, writer);
                    return;
                }
                if (value is ShareLink)
                {
                    WriteProperty(".tag", "share_link", writer, enc.StringEncoder.Instance);
                    ShareLink.Encoder.EncodeFields((ShareLink)value, writer);
                    return;
                }
                if (value is CreateLink)
                {
                    WriteProperty(".tag", "create_link", writer, enc.StringEncoder.Instance);
                    CreateLink.Encoder.EncodeFields((CreateLink)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileAction" />.</para>
        /// </summary>
        private class FileActionDecoder : enc.UnionDecoder<FileAction>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileAction" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileAction Create()
            {
                return new FileAction();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override FileAction Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "edit_contents":
                        return EditContents.Decoder.DecodeFields(reader);
                    case "invite_viewer":
                        return InviteViewer.Decoder.DecodeFields(reader);
                    case "invite_viewer_no_comment":
                        return InviteViewerNoComment.Decoder.DecodeFields(reader);
                    case "unshare":
                        return Unshare.Decoder.DecodeFields(reader);
                    case "relinquish_membership":
                        return RelinquishMembership.Decoder.DecodeFields(reader);
                    case "share_link":
                        return ShareLink.Decoder.DecodeFields(reader);
                    case "create_link":
                        return CreateLink.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Change or edit contents of the file.</para>
        /// </summary>
        public sealed class EditContents : FileAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<EditContents> Encoder = new EditContentsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<EditContents> Decoder = new EditContentsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="EditContents" />
            /// class.</para>
            /// </summary>
            private EditContents()
            {
            }

            /// <summary>
            /// <para>A singleton instance of EditContents</para>
            /// </summary>
            public static readonly EditContents Instance = new EditContents();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="EditContents" />.</para>
            /// </summary>
            private class EditContentsEncoder : enc.StructEncoder<EditContents>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(EditContents value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="EditContents" />.</para>
            /// </summary>
            private class EditContentsDecoder : enc.StructDecoder<EditContents>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="EditContents" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override EditContents Create()
                {
                    return new EditContents();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override EditContents DecodeFields(enc.IJsonReader reader)
                {
                    return EditContents.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Add a member with view permissions.</para>
        /// </summary>
        public sealed class InviteViewer : FileAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InviteViewer> Encoder = new InviteViewerEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InviteViewer> Decoder = new InviteViewerDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InviteViewer" />
            /// class.</para>
            /// </summary>
            private InviteViewer()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InviteViewer</para>
            /// </summary>
            public static readonly InviteViewer Instance = new InviteViewer();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InviteViewer" />.</para>
            /// </summary>
            private class InviteViewerEncoder : enc.StructEncoder<InviteViewer>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InviteViewer value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InviteViewer" />.</para>
            /// </summary>
            private class InviteViewerDecoder : enc.StructDecoder<InviteViewer>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InviteViewer" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InviteViewer Create()
                {
                    return new InviteViewer();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InviteViewer DecodeFields(enc.IJsonReader reader)
                {
                    return InviteViewer.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Add a member with view permissions but no comment permissions.</para>
        /// </summary>
        public sealed class InviteViewerNoComment : FileAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InviteViewerNoComment> Encoder = new InviteViewerNoCommentEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InviteViewerNoComment> Decoder = new InviteViewerNoCommentDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InviteViewerNoComment" />
            /// class.</para>
            /// </summary>
            private InviteViewerNoComment()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InviteViewerNoComment</para>
            /// </summary>
            public static readonly InviteViewerNoComment Instance = new InviteViewerNoComment();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InviteViewerNoComment" />.</para>
            /// </summary>
            private class InviteViewerNoCommentEncoder : enc.StructEncoder<InviteViewerNoComment>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InviteViewerNoComment value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InviteViewerNoComment" />.</para>
            /// </summary>
            private class InviteViewerNoCommentDecoder : enc.StructDecoder<InviteViewerNoComment>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InviteViewerNoComment"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InviteViewerNoComment Create()
                {
                    return new InviteViewerNoComment();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InviteViewerNoComment DecodeFields(enc.IJsonReader reader)
                {
                    return InviteViewerNoComment.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Stop sharing this file.</para>
        /// </summary>
        public sealed class Unshare : FileAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Unshare> Encoder = new UnshareEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Unshare> Decoder = new UnshareDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Unshare" /> class.</para>
            /// </summary>
            private Unshare()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Unshare</para>
            /// </summary>
            public static readonly Unshare Instance = new Unshare();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Unshare" />.</para>
            /// </summary>
            private class UnshareEncoder : enc.StructEncoder<Unshare>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Unshare value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Unshare" />.</para>
            /// </summary>
            private class UnshareDecoder : enc.StructDecoder<Unshare>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Unshare" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Unshare Create()
                {
                    return new Unshare();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Unshare DecodeFields(enc.IJsonReader reader)
                {
                    return Unshare.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Relinquish one's own membership to the file.</para>
        /// </summary>
        public sealed class RelinquishMembership : FileAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<RelinquishMembership> Encoder = new RelinquishMembershipEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<RelinquishMembership> Decoder = new RelinquishMembershipDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="RelinquishMembership" />
            /// class.</para>
            /// </summary>
            private RelinquishMembership()
            {
            }

            /// <summary>
            /// <para>A singleton instance of RelinquishMembership</para>
            /// </summary>
            public static readonly RelinquishMembership Instance = new RelinquishMembership();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="RelinquishMembership" />.</para>
            /// </summary>
            private class RelinquishMembershipEncoder : enc.StructEncoder<RelinquishMembership>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(RelinquishMembership value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="RelinquishMembership" />.</para>
            /// </summary>
            private class RelinquishMembershipDecoder : enc.StructDecoder<RelinquishMembership>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="RelinquishMembership"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override RelinquishMembership Create()
                {
                    return new RelinquishMembership();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override RelinquishMembership DecodeFields(enc.IJsonReader reader)
                {
                    return RelinquishMembership.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>This action is deprecated. Use create_link instead.</para>
        /// </summary>
        public sealed class ShareLink : FileAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<ShareLink> Encoder = new ShareLinkEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<ShareLink> Decoder = new ShareLinkDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="ShareLink" /> class.</para>
            /// </summary>
            private ShareLink()
            {
            }

            /// <summary>
            /// <para>A singleton instance of ShareLink</para>
            /// </summary>
            public static readonly ShareLink Instance = new ShareLink();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="ShareLink" />.</para>
            /// </summary>
            private class ShareLinkEncoder : enc.StructEncoder<ShareLink>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(ShareLink value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="ShareLink" />.</para>
            /// </summary>
            private class ShareLinkDecoder : enc.StructDecoder<ShareLink>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="ShareLink" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override ShareLink Create()
                {
                    return new ShareLink();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override ShareLink DecodeFields(enc.IJsonReader reader)
                {
                    return ShareLink.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Create a shared link to the file.</para>
        /// </summary>
        public sealed class CreateLink : FileAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<CreateLink> Encoder = new CreateLinkEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<CreateLink> Decoder = new CreateLinkDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="CreateLink" /> class.</para>
            /// </summary>
            private CreateLink()
            {
            }

            /// <summary>
            /// <para>A singleton instance of CreateLink</para>
            /// </summary>
            public static readonly CreateLink Instance = new CreateLink();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="CreateLink" />.</para>
            /// </summary>
            private class CreateLinkEncoder : enc.StructEncoder<CreateLink>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(CreateLink value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="CreateLink" />.</para>
            /// </summary>
            private class CreateLinkDecoder : enc.StructDecoder<CreateLink>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="CreateLink" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override CreateLink Create()
                {
                    return new CreateLink();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override CreateLink DecodeFields(enc.IJsonReader reader)
                {
                    return CreateLink.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : FileAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
