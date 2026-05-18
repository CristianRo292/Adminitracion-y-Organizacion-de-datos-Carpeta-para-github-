


from gtts import gTTS
import pygame
from datetime import datetime

texto = "Un texto es una composición ordenada de signos escritos u \
orales con intención comunicativa y sentido unitario,\
      caracterizado por la coherencia y cohesión. Los textos\
          pueden ser narrativos (cuentos), descriptivos (guías),\
              argumentativos (ensayos), informativos (noticias) o instructivos (manuales). "

tts = gTTS(text = texto, lang = "es", tld = "com.mx")
nombre = f"audio{datetime.now().second()}.mp3"
tts.save("nombre")
pygame.mixer.init()
pygame.mixer.music.load("C://Users/roc53/Documents/SEMESTRE 4/AdmOrgaDatos/Unity/textoaVoz/" + nombre)
pygame.mixer.music.play()
while pygame.mixer.music.get_busy():
    continue