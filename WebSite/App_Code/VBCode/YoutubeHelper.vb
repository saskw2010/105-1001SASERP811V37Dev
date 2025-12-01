Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Linq
Imports Google.GData.Client
Imports Google.YouTube


Public Class YouTubeVideoObject
    Public Property VideoId() As String
        Get
            Return m_VideoId
        End Get
        Set(value As String)
            m_VideoId = Value
        End Set
    End Property
    Private m_VideoId As String
    Public Property Title() As String
        Get
            Return m_Title
        End Get
        Set(value As String)
            m_Title = Value
        End Set
    End Property
    Private m_Title As String
End Class

Public Class YouTubeVideoHelper
    Const YOUTUBE_CHANNEL As String = "BobinaMusic"
    Const YOUTUBE_DEVELOPER_KEY As String = "AI39si6JqO_f2b_JWSV3QUbcwg5S-1RJ4-kiieosBZy9r1ORkCAv7BT5tLp579Tzmly8rvOVm3Jyueq3ZVqUNt1blS4DcoVppA"

    Public Shared Function GetVideos() As YouTubeVideoObject()
        Dim settings As New YouTubeRequestSettings("Bobina Channel", YOUTUBE_DEVELOPER_KEY)
        Dim request As New YouTubeRequest(settings)

        Dim feedUrl As String = [String].Format("https://www.youtube.com/feeds/videos.xml?channel_id=UCcwQdrlue4igPi6qez2smZQ", YOUTUBE_CHANNEL)
        Dim videoFeed As Feed(Of Video) = request.[Get](Of Video)(New Uri(feedUrl))

        Return (From video In videoFeed.Entries Select New YouTubeVideoObject() With { _
              .VideoId = Right(video.Id, Len(video.Id) - 9), _
             .Title = video.Title _
         }).ToArray()

    End Function
End Class
