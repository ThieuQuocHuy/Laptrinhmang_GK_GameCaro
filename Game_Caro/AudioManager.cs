using NAudio.Wave;
using System;
using System.Windows.Forms;

namespace Game_Caro
{
    public class AudioManager
    {
        private static WaveOutEvent backgroundPlayer;
        private static WaveOutEvent effectPlayer;
        private static AudioFileReader backgroundReader;
        private static AudioFileReader effectReader;

        static AudioManager()
        {
            backgroundPlayer = new WaveOutEvent();
            effectPlayer = new WaveOutEvent();
        }

        public static void PlayBackground(string path)
        {
            try
            {
                if (backgroundReader != null)
                {
                    backgroundPlayer.Stop();
                    backgroundReader.Dispose();
                }

                backgroundReader = new AudioFileReader(path);
                backgroundPlayer.Init(backgroundReader);
                backgroundPlayer.Play();

                // Tự động phát lại khi kết thúc
                backgroundPlayer.PlaybackStopped += (s, e) =>
                {
                    backgroundReader.Position = 0;
                    backgroundPlayer.Play();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phát nhạc nền: " + ex.Message);
            }
        }

        public static void PlayEffect(string path)
        {
            try
            {
                if (effectReader != null)
                {
                    effectReader.Dispose();
                }

                effectReader = new AudioFileReader(path);
                effectPlayer.Init(effectReader);
                effectPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phát âm thanh: " + ex.Message);
            }
        }

        public static void StopBackground()
        {
            if (backgroundPlayer != null)
            {
                backgroundPlayer.Stop();
            }
        }

        public static void Dispose()
        {
            backgroundPlayer?.Dispose();
            effectPlayer?.Dispose();
            backgroundReader?.Dispose();
            effectReader?.Dispose();
        }

        // Thêm phương thức điều chỉnh âm lượng nếu cần
        public static void SetBackgroundVolume(float volume) // volume từ 0.0 đến 1.0
        {
            if (backgroundPlayer != null)
            {
                backgroundPlayer.Volume = volume;
            }
        }

        public static void SetEffectVolume(float volume) // volume từ 0.0 đến 1.0
        {
            if (effectPlayer != null)
            {
                effectPlayer.Volume = volume;
            }
        }
    }
}