<template>
  <v-container>
    <v-breadcrumbs
      :items="[
        {
          text: 'Назад',
          disabled: false,
          href: '/',
        },
      ]"
      divider="-"
    ></v-breadcrumbs>
    <div class="mt-6">
      <div>
        <v-row ma-0>
          <div class="image">
            <v-img
              max-height="300"
              max-width="400"
              src="https://picsum.photos/id/11/500/300"
            ></v-img>
          </div>
          <h1 class="ml-12">
            {{ application.title }}
          </h1>
        </v-row>
      </div>
      <div>
        <div class="parameters mt-4">
          <p class="ma-0">
            <span class="parameter-title">Стадия готовности: </span>
            <span class="ml-2">{{ application.completeStage }}</span>
          </p>
          <p class="ma-0">
            <span class="parameter-title">Кейсы использования продукта: </span>
            <span class="ml-2">{{ application.useCases }}</span>
          </p>
          <p class="ma-0">
            <span class="parameter-title">Наличие пилотного проекта: </span>
            <span class="ml-2">{{ application.pilotProjectExists }}</span>
          </p>
          <p class="ma-0">
            <span class="parameter-title"
              >Требуется ли сертификация продукта:
            </span>
            <span class="ml-2">{{ application.certificationNeed }}</span>
          </p>
          <p class="ma-0">
            <span class="parameter-title">Польза продукта: </span>
            <span class="ml-2">{{ application.productBenefits }}</span>
          </p>
          <p>
            <span class="parameter-title">Краткое описание: </span>
            <span class="ml-2">{{ application.shortDescription }}</span>
          </p>
          <p>
            <span class="parameter-title"
              >Организация Московского транспорта, интересная в первую очередь:
            </span>
            <span class="ml-2">{{ application.firstOrderOrganisation }}</span>
          </p>
          <p>
            <span class="parameter-title"
              >Запрос к акселератору и видение пилотного проекта:
            </span>
            <span class="ml-2">{{ application.requestToAccelerator }}</span>
          </p>
        </div>
      </div>
    </div>
  </v-container>
</template>

<script>
export default {
  data: () => ({
    text: "",
  }),
  computed: {
    application() {
      const applicationId = this.$router.currentRoute.params.id;
      return this.$store.getters.applicationById(applicationId);
    },
  },
};
</script>
<style scoped>
p {
  margin: 0 !important;
}
.image {
  padding-left: 12px !important;
}
h1 {
  margin-top: 0;
}

::v-deep .v-slider__tick {
  width: 0px !important;
  height: 0px !important;
  opacity: 0 !important;
}
</style>