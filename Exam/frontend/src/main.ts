import './assets/main.css'

import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import { plugin, defaultConfig } from '@formkit/vue'
import config from '../formkit.config'

const app = createApp(App)

app.use(router)
app.use(plugin, defaultConfig(config))
app.mount('#app')
