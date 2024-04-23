import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// https://vitejs.dev/config/
export default defineConfig({
    plugins: [react()],
    resolve: {
        alias: {
            // componenst: '/src/componenst',
            // provider: '/src/provider',
            // services: '/src/services',
            // utils: '/src/utils',
            // hooks: '/src/hooks',
            // animation: '/src/animation.module.css',
            // interface: '/src/interface.i.ts',
            src: '/src',
        },
    },
})
