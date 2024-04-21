using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VPControll : MonoBehaviour
{
    public VideoClip[] videoClips; // ћассив видеоклипов, которые будут воспроизводитьс€
    private VideoPlayer videoPlayer; // —сылка на компонент VideoPlayer
    private int currentIndex = 0; // “екущий индекс видеоклипа в массиве

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();

    }

    // ћетод дл€ воспроизведени€ видео по индексу
    public void PlayVideoByIndex(int index)
    {
        // ѕровер€ем, что индекс находитс€ в пределах массива видеоклипов
        if (index >= 0 && index < videoClips.Length)
        {
            // ”станавливаем текущий индекс
            currentIndex = index;

            // ”станавливаем выбранный видеоклип дл€ проигрывани€
            videoPlayer.clip = videoClips[currentIndex];

            // «апускаем проигрывание
            videoPlayer.Play();
        }
        else
        {
            Debug.LogWarning("Invalid video index!");
        }
    }
}
