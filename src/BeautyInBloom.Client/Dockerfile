FROM node:14-alpine AS development

ENV NODE_ENV development

# Add a work directory
WORKDIR /app

# Cache and Install dependencies
COPY src/BeautyInBloom.Client/package.json .
RUN yarn

# Copy app files
COPY . .

# Expose port
EXPOSE 3000

# Start the app
CMD [ "yarn", "dev" ]