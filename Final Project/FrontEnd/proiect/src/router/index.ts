import { createRouter, createWebHistory } from 'vue-router'
import LoginPage from '@/views/LoginPage.vue'
import SignUpPage from '@/views/SignUpPage.vue'
import HomePage from '@/views/HomePage.vue'
import MainPage from '@/views/MainPage.vue'
import ProfilePage from '@/views/ProfilePage.vue'
import OtherProfile from '@/views/OtherProfile.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/Login',
      name: 'Login',
      component: LoginPage
    },
    {
      path: '/SignUp',
      name: 'SignUp',
      component: SignUpPage
    },
    {
      path: '/',
      name: 'HomePage',
      component: HomePage
    },
    {
      path: '/MainPage',
      name: 'MainPage',
      component: MainPage
    },
    {
      path: '/ProfilePage',
      name: 'ProfilePage',
      component: ProfilePage
    },
    {
      path: '/OtherProfile',
      name: 'OtherProfile',
      component: OtherProfile
    }
  ]
})

export default router
