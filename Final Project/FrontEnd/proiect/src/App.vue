<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router';

// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getAnalytics } from "firebase/analytics";
import axios from './Helpers/AxiosInstance'
import { getMessaging, getToken, onMessage } from 'firebase/messaging'
import { store } from './Helpers/Authenticated'
import { useToast } from 'vue-toastification'

const toast = useToast();

const firebaseConfig = {
  apiKey: "AIzaSyDRX7zL9r7zaOhIl2NRa20XlHcrGYH5HDI",
  authDomain: "proiect-269dd.firebaseapp.com",
  projectId: "proiect-269dd",
  storageBucket: "proiect-269dd.appspot.com",
  messagingSenderId: "763123456703",
  appId: "1:763123456703:web:205befb2d4c81d9872040a",
  measurementId: "G-VTC9Q480RQ"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);
const messaging = getMessaging()

onMessage(messaging, (payload) => {
  toast.info(payload.notification?.body);
})

getToken(messaging, {
  vapidKey:
    'BCb1UIxc1axpsVuRgMJYGB6-UF-U8y8GxHyVNk53q-AO3U-c-4JL0-3eaGPQS3QXedQIgQro7ZIIt42NdRF8Bos'
})
    .then((currentToken) => {
      if (currentToken) {
        if (store.isAuthenticated === true) {
          axios.patch(`User/device-token/${currentToken}`);
          localStorage.setItem('device_token',currentToken);
        }
      } else {
        console.log('No registration token available. Request permission to generate one.')
      }
    })
    .catch((err) => {
      console.log('An error occurred while retrieving token. ', err)
    })

</script>

<template>
  <RouterView />
</template>

<style scoped>

</style>
