import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react'

// https://vitejs.dev/config/
export default defineConfig({
    plugins: [react()],
    build: {
        outDir: "../wwwroot"
    },
    server: {
        proxy: {
            '/api': {
                target: 'http://localhost:5142',
                changeOrigin: true,
                secure: false
            }
        }
    }
})