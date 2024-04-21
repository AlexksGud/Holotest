using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VPControll : MonoBehaviour
{
    public VideoClip[] videoClips; // ������ �����������, ������� ����� ����������������
    private VideoPlayer videoPlayer; // ������ �� ��������� VideoPlayer
    private int currentIndex = 0; // ������� ������ ���������� � �������

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

    }

    // ����� ��� ��������������� ����� �� �������
    public void PlayVideoByIndex(int index)
    {
        // ���������, ��� ������ ��������� � �������� ������� �����������
        if (index >= 0 && index < videoClips.Length)
        {
            // ������������� ������� ������
            currentIndex = index;

            // ������������� ��������� ��������� ��� ������������
            videoPlayer.clip = videoClips[currentIndex];

            // ��������� ������������
            videoPlayer.Play();
        }
        else
        {
            Debug.LogWarning("Invalid video index!");
        }
    }
}
